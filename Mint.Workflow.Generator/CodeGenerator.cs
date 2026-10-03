using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.IO;
using System.Text.RegularExpressions;
using Scriban;

namespace Mint.Workflow.Generator {
	/// <summary>
	/// 代码生成器
	/// </summary>
	public class CodeGenerator {
		/// <summary>
		/// 获取所有表属性
		/// </summary>
		public void GenerateCode(){
			// 1. 获取所有表
			// 1.1 创建数据库表的链接地址
			var connectionString = Environment.GetEnvironmentVariable("MINT_WORKFLOW_DB_CONNECTION") ??
			                       "Host=localhost;Port=5432;Database=Mint.Workflow;Username=postgres;Password=YangMufa666";
			//  1.2 获取mint_workflow数据库public schema下所有表
			List<TableMapMetadata> tableMetadataList = GetTables(connectionString);

			// 1.3. 生成代码
			foreach (var tableMetadata in tableMetadataList) {
				// 1.3.1. 生成Model
				GenerateBusiness("Template/Model.sbn", "Mint.Workflow.Entity/Models", $"{tableMetadata.ClassName}.cs",
					tableMetadata, false);

				// 1.3.2.1. 生成IRepositoryPartial
				GenerateBusiness("Template/Partial/IRepository.sbn", "Mint.Workflow.Repository/IRepositorys/Partial",
					$"I{tableMetadata.ClassName}Repository.cs", tableMetadata, false);
				// 1.3.2.2. 生成IRepository
				GenerateBusiness("Template/IRepository.sbn", "Mint.Workflow.Repository/IRepositorys",
					$"I{tableMetadata.ClassName}Repository.cs", tableMetadata, false);

				// 1.3.3.1. 生成RepositoryPartial
				GenerateBusiness("Template/Partial/Repository.sbn", "Mint.Workflow.Repository/Repositorys/Partial",
					$"{tableMetadata.ClassName}Repository.cs", tableMetadata, false);
				// 1.3.3.2. 生成Repository
				GenerateBusiness("Template/Repository.sbn", "Mint.Workflow.Repository/Repositorys",
					$"{tableMetadata.ClassName}Repository.cs", tableMetadata, false);

				// 1.3.4.1. 生成IServicePartial
				GenerateBusiness("Template/Partial/IService.sbn", "Mint.Workflow.Service/IServices/Partial",
					$"I{tableMetadata.ClassName}Service.cs", tableMetadata, false);
				// 1.3.4.2. 生成IService
				GenerateBusiness("Template/IService.sbn", "Mint.Workflow.Service/IServices",
					$"I{tableMetadata.ClassName}Service.cs", tableMetadata, false);

				// 1.3.5.1. 生成ServicePartial
				GenerateBusiness("Template/Partial/Service.sbn", "Mint.Workflow.Service/Services/Partial",
					$"{tableMetadata.ClassName}Service.cs", tableMetadata, false);
				// 1.3.5.1. 生成Service
				GenerateBusiness("Template/Service.sbn", "Mint.Workflow.Service/Services",
					$"{tableMetadata.ClassName}Service.cs", tableMetadata, false);

				// 1.3.6.1. 生成ControllerPartial
				GenerateBusiness("Template/Partial/Controller.sbn", "Mint.Workflow.WebApi/Controllers/Partial",
					$"{tableMetadata.ClassName}Controller.cs", tableMetadata, false);
				// 1.3.6.2. 生成Controller
				GenerateBusiness("Template/Controller.sbn", "Mint.Workflow.WebApi/Controllers",
					$"{tableMetadata.ClassName}Controller.cs", tableMetadata, false);
			}

			// 1.3.3.1. 生成IDbContextPartial
			GenerateIDbContext("Template/Partial/IDbContext.sbn", "Mint.Workflow.Repository/IDbContexts/Partial",
				$"IDbContext.cs",
				tableMetadataList, false);
			// 1.3.3.2. 生成IDbContext
			GenerateIDbContext("Template/IDbContext.sbn", "Mint.Workflow.Repository/IDbContexts", $"IDbContext.cs",
				tableMetadataList, false);

			// 1.3.4.1. 生成DbContextPartial
			GenerateDbContext("Template/Partial/DbContext.sbn", "Mint.Workflow.Repository/DbContexts/Partial",
				$"DbContext.cs",
				tableMetadataList, false);
			// 1.3.4.2. 生成DbContext
			GenerateDbContext("Template/DbContext.sbn", "Mint.Workflow.Repository/DbContexts", $"DbContext.cs",
				tableMetadataList, false);

			// 1.3.5. 生成Program
			GenerateProgram("Template/Program.sbn", "Mint.Workflow.WebApi", $"Program.cs", tableMetadataList);
		}

		/// <summary>
		/// 业务代码生成
		/// </summary>
		/// <param name="TemplatePath"></param>
		/// <param name="ModelFilePath"></param>
		/// <param name="ModelFileName"></param>
		/// <param name="tableMetadata"></param>
		/// <param name="skipIfExists">文件已存在时是否跳过生成</param>
		private void GenerateBusiness(string templatePath, string generateFilePath, string generateFileName,
		TableMapMetadata tableMetadata, bool skipIfExists){
			// 1. 加载模板文件
			string templateContent = File.ReadAllText(templatePath);
			// 2. 模板内容解析
			Template templateParser = Template.Parse(templateContent);
			// 3. 模板内容渲染--这种方法插值语法只支持全小写
			string templateResult = templateParser.Render(new {
				name = tableMetadata.ClassName,        //模型名
				comment = tableMetadata.TableComment,  //表注释
				tablename = tableMetadata.TableName,   //表名
				properties = tableMetadata.Properties, //字段集合
				primarykey = tableMetadata.PrimaryKey, //主键字段
			});
			// 4. 创建存放的文件夹
			string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
			// 获取项目的根目录的上一级目录
			DirectoryInfo directoryInfo = new DirectoryInfo(currentDirectory);
			for (var i = 0; i < 4; i++) { // Mint.Workflow/debug/bing/x86
				directoryInfo = directoryInfo.Parent;
			}

			Console.WriteLine(directoryInfo.FullName);
			string projectDirectory = directoryInfo.FullName;
			//指定生成文件的目录
			string codeDirectory = Path.Combine(projectDirectory, generateFilePath);
			if (!Directory.Exists(codeDirectory)) {
				Directory.CreateDirectory(codeDirectory);
			}

			//生成文件的完整路径
			var outputFilePath = Path.Combine(codeDirectory, generateFileName);
			if (skipIfExists && File.Exists(outputFilePath)) {
				return;
			}

			// 4. 生成 .cs 文件
			File.WriteAllText(outputFilePath, templateResult);
		}

		/// <summary>
		/// 生成IDbContext代码
		/// </summary>
		/// <param name="TemplatePath"></param>
		/// <param name="ModelFilePath"></param>
		/// <param name="ModelFileName"></param>
		/// <param name="tableMetadataList"></param>
		/// <param name="skipIfExists">文件已存在时是否跳过生成</param>
		private void GenerateIDbContext(string templatePath, string generateFilePath, string generateFileName,
		List<TableMapMetadata> tableMetadataList, bool skipIfExists){
			// 1. 加载模板文件
			string templateContent = File.ReadAllText(templatePath);
			// 2. 模板内容解析
			Template templateParser = Template.Parse(templateContent);
			// 3. 模板内容渲染--这种方法插值语法只支持全小写
			string templateResult = templateParser.Render(new {
				entitys = tableMetadataList, //表集合
			});
			// 4. 创建存放的文件夹夹
			string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
			// 获取项目的根目录的上一级目录
			DirectoryInfo directoryInfo = new DirectoryInfo(currentDirectory);
			for (var i = 0; i < 4; i++) {
				directoryInfo = directoryInfo.Parent;
			}

			Console.WriteLine(directoryInfo.FullName);
			string projectDirectory = directoryInfo.FullName;
			//指定生成文件的目录
			string codeDirectory = Path.Combine(projectDirectory, generateFilePath);
			if (!Directory.Exists(codeDirectory)) {
				Directory.CreateDirectory(codeDirectory);
			}

			//生成文件的完整路径
			var outputFilePath = Path.Combine(codeDirectory, generateFileName);
			if (skipIfExists && File.Exists(outputFilePath)) {
				return;
			}

			// 4. 生成 .cs 文件
			File.WriteAllText(outputFilePath, templateResult);
		}

		/// <summary>
		/// 生成DbContext代码
		/// </summary>
		/// <param name="TemplatePath"></param>
		/// <param name="ModelFilePath"></param>
		/// <param name="ModelFileName"></param>
		/// <param name="tableMetadataList"></param>
		/// <param name="skipIfExists">文件已存在时是否跳过生成</param>
		private void GenerateDbContext(string templatePath, string generateFilePath, string generateFileName,
		List<TableMapMetadata> tableMetadataList, bool skipIfExists){
			// 1. 加载模板文件
			string templateContent = File.ReadAllText(templatePath);
			// 2. 模板内容解析
			Template templateParser = Template.Parse(templateContent);
			// 3. 模板内容渲染--这种方法插值语法只支持全小写
			string templateResult = templateParser.Render(new {
				entitys = tableMetadataList, // 确保模板中可以访问 entitys 变量
			});
			// 4. 创建存放的文件夹夹
			string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
			// 获取项目的根目录的上一级目录
			DirectoryInfo directoryInfo = new DirectoryInfo(currentDirectory);
			for (var i = 0; i < 4; i++) {
				directoryInfo = directoryInfo.Parent;
			}

			Console.WriteLine(directoryInfo.FullName);
			string projectDirectory = directoryInfo.FullName;
			//指定生成文件的目录
			string codeDirectory = Path.Combine(projectDirectory, generateFilePath);
			if (!Directory.Exists(codeDirectory)) {
				Directory.CreateDirectory(codeDirectory);
			}

			//生成文件的完整路径
			var outputFilePath = Path.Combine(codeDirectory, generateFileName);
			if (skipIfExists && File.Exists(outputFilePath)) {
				return;
			}

			// 4. 生成 .cs 文件
			File.WriteAllText(outputFilePath, templateResult);
		}

		/// <summary>
		/// 生成Program代码
		/// </summary>
		/// <param name="TemplatePath"></param>
		/// <param name="ModelFilePath"></param>
		/// <param name="ModelFileName"></param>
		/// <param name="entity"></param>
		private void GenerateProgram(string templatePath, string generateFilePath, string generateFileName,
		List<TableMapMetadata> tableMetadataList){
			// 1. 加载模板文件
			string templateContent = File.ReadAllText(templatePath);
			// 2. 模板内容解析
			Template templateParser = Template.Parse(templateContent);
			// 3. 模板内容渲染--这种方法插值语法只支持全小写
			string templateResult = templateParser.Render(new {
				entitys = tableMetadataList, // 确保模板中可以访问 entitys 变量
			});
			// 4. 创建存放的文件夹夹
			string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
			// 获取项目的根目录的上一级目录
			DirectoryInfo directoryInfo = new DirectoryInfo(currentDirectory);
			for (var i = 0; i < 4; i++) {
				directoryInfo = directoryInfo.Parent;
			}

			Console.WriteLine(directoryInfo.FullName);
			string projectDirectory = directoryInfo.FullName;
			//指定生成文件的目录
			string codeDirectory = Path.Combine(projectDirectory, generateFilePath);
			if (!Directory.Exists(codeDirectory)) {
				Directory.CreateDirectory(codeDirectory);
			}

			//生成文件的完整路径
			var outputFilePath = Path.Combine(codeDirectory, generateFileName);
			// 4. 生成 .cs 文件
			File.WriteAllText(outputFilePath, templateResult);
		}

		/// <summary>
		/// 1-1. 获取Mint.Workflow数据库所有表
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		private List<TableMapMetadata> GetTables(string connectionString){
			List<TableMapMetadata> tableMetadataList = new List<TableMapMetadata>();
			// 1.2 创建PostgreSQL连接
			using (var connection = new NpgsqlConnection(connectionString)) {
				// 1.3 打开数据库连接
				connection.Open();
				// 1.4 查询所有基础表
				var tableCommand =
					new NpgsqlCommand(@"select table_name
                    from information_schema.tables
                    where table_schema = 'public'
                      and table_type = 'BASE TABLE'
                      and table_name like 'm\_%' escape '\'
                    order by table_name", connection);
				// 1.5 遍历所有表
				using (var reader = tableCommand.ExecuteReader()) {
					// 1.6遍历所有表
					while (reader.Read()) {
						// 1.7 获取表名
						var tableName = reader.GetString(0);
						// 1.8 转换成模板实体
						TableMapMetadata tableMetadata = new TableMapMetadata();
						tableMetadata.ClassName = GetClassName(tableName);
						tableMetadata.TableName = tableName;
						tableMetadata.TableComment = GetTableComment(connectionString, tableName);
						tableMetadata.Properties = GetTableFields(connectionString, tableName);
						tableMetadata.PrimaryKey =
							tableMetadata.Properties.SingleOrDefault(propertyMetadata => propertyMetadata.IsPrimaryKey)
							?? throw new InvalidOperationException(
								$"Table public.{tableName} does not have a single-column primary key.");
						tableMetadataList.Add(tableMetadata);
					}
				}
			}

			return tableMetadataList;
		}

		/// <summary>
		/// 1-2. 表名转换成大驼峰
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		private string GetClassName(string input){
			if (string.IsNullOrWhiteSpace(input)) {
				return input;
			}

			// 去掉前缀 "m_"
			if (input.StartsWith("m_")) {
				input = input.Substring(2);
			}

			// 处理各种分隔符（统一替换为空格）
			input = Regex.Replace(input, @"[\s\-_\.\,\/\\]", " ");
			// 处理数字前的字母（如 "user1" -> "User1"）
			input = Regex.Replace(input, @"([a-zA-Z])(\d)", "$1 $2");
			// 处理连续大写字母（如 "AAUser" -> "A A User"）
			input = Regex.Replace(input, @"([A-Z])([A-Z]+)",
				m => m.Groups[1].Value + " " + m.Groups[2].Value.ToLower());
			// 处理大小写混合（如 "uSeR" -> "User"）
			input = Regex.Replace(input, @"([A-Z])([A-Z][a-z])", "$1 $2");
			input = Regex.Replace(input, @"([a-z])([A-Z])", "$1 $2");
			// 使用TextInfo处理标题化
			var textInfo = CultureInfo.InvariantCulture.TextInfo;
			input = textInfo.ToTitleCase(input.ToLower());
			// 移除所有空格并处理特殊字符
			var result = new StringBuilder();
			foreach (char c in input) {
				if (char.IsLetterOrDigit(c))
					result.Append(c);
			}

			// 确保首字母大写
			if (result.Length > 0) {
				result[0] = char.ToUpper(result[0]);
			}

			return result.ToString();
		}

		/// <summary>
		/// 2. 获取表的字段
		/// </summary>
		/// <param name="connectionString"></param>
		private List<PropertyMapMetadata> GetTableFields(string connectionString, string tableName){
			// 属性实体集合
			List<PropertyMapMetadata> propertyMetadataList = new List<PropertyMapMetadata>();
			// 2.1 创建PostgreSQL连接
			using (var connection = new NpgsqlConnection(connectionString)) {
				// 2.2 打开连接
				connection.Open();
				// 2.3 创建获取表所有字段的命令
				var columnCommand =
					new NpgsqlCommand(
						@"select c.column_name, c.data_type, c.udt_name, c.is_identity,
                             (pk.column_name is not null) as is_primary_key
                      from information_schema.columns c
                      left join (
                          select kcu.table_schema, kcu.table_name, min(kcu.column_name) as column_name
                          from information_schema.table_constraints tc
                          join information_schema.key_column_usage kcu
                            on kcu.constraint_catalog = tc.constraint_catalog
                           and kcu.constraint_schema = tc.constraint_schema
                           and kcu.constraint_name = tc.constraint_name
                           and kcu.table_schema = tc.table_schema
                           and kcu.table_name = tc.table_name
                          where tc.constraint_type = 'PRIMARY KEY'
                            and tc.table_schema = 'public'
                          group by kcu.table_schema, kcu.table_name
                          having count(*) = 1
                      ) pk
                        on pk.table_schema = c.table_schema
                       and pk.table_name = c.table_name
                       and pk.column_name = c.column_name
                      where c.table_name = @TableName and c.table_schema = 'public'
                      order by c.ordinal_position",
						connection);
				columnCommand.Parameters.AddWithValue("@TableName", tableName);
				// 2.4 读取表所有字段
				using (var columnReader = columnCommand.ExecuteReader()) {
					// 2.5 遍历所有字段
					while (columnReader.Read()) {
						// 2.6 读取每个字段
						var columnName = columnReader.GetString(0); // 数据库字段名
						var dataType = columnReader.GetString(1);   // PostgreSQL通用字段类型
						var udtName = columnReader.GetString(2);    // PostgreSQL底层字段类型
						var isIdentity = string.Equals(columnReader.GetString(3), "YES",
							StringComparison.OrdinalIgnoreCase);
						var isPrimaryKey = columnReader.GetBoolean(4);
						// 2.7 转换成属性实体
						PropertyMapMetadata propertyMetadata = new PropertyMapMetadata();
						propertyMetadata.PropertyName = columnName;
						propertyMetadata.PropertyType = GetColumnTypeByPostgreSqlType(dataType, udtName);
						propertyMetadata.IsPrimaryKey = isPrimaryKey;
						propertyMetadata.IsIdentity = isIdentity;
						// 2.8 赋值到List<PropertyMapMetadata>
						propertyMetadataList.Add(propertyMetadata);
					}
				}
			}

			return propertyMetadataList;
		}

		/// <summary>
		/// 3. 获取所有表的注释
		/// </summary>
		private string GetTableComment(string connectionString, string tableName){
			// 3.1 创建PostgreSQL连接
			using (var connection = new NpgsqlConnection(connectionString)) {
				// 3.2 打开连接
				connection.Open();
				// 3.3 创建表注释的命令
				var commentCommand = new NpgsqlCommand(
					@"
                    select
                        obj_description(c.oid, 'pg_class')
                    from
                        pg_catalog.pg_class c
                        join pg_catalog.pg_namespace n on n.oid = c.relnamespace
                    where
                        n.nspname = 'public'
                    and
                        c.relname = @TableName
                    and
                        c.relkind in ('r', 'p')"
					, connection
				);
				commentCommand.Parameters.AddWithValue("@TableName", tableName);
				// 3.4 读取表注释
				return commentCommand.ExecuteScalar()?.ToString();
			}
		}

		/// <summary>
		/// 4. 获取表字段类型
		/// </summary>
		private string GetColumnTypeByPostgreSqlType(string dataType, string udtName){
			//  4.1. 判断是否为空
			if (string.IsNullOrWhiteSpace(dataType) && string.IsNullOrWhiteSpace(udtName)) {
				return "null";
			}

			// 4.2 优先使用udt_name识别PostgreSQL底层类型
			string normalizedType = (udtName ?? dataType).ToLowerInvariant();
			// 4.3 根据类型返回对应的C#数据类型
			switch (normalizedType) {
				// 整数类型
				case "int2":
				case "smallint":
					return "short";
				case "int4":
				case "integer":
					return "int";
				case "int8":
				case "bigint":
					return "long";
				// 小数类型
				case "float4":
				case "real":
					return "float";
				case "float8":
				case "double precision":
					return "double";
				case "numeric":
				case "decimal":
					return "decimal";
				// 字符串类型
				case "bpchar":
				case "char":
				case "varchar":
				case "character varying":
				case "text":
				case "json":
				case "jsonb":
					return "string";
				// 二进制数据
				case "bytea":
					return "byte[]";
				// 日期时间类型
				case "date":
				case "timestamp":
				case "timestamptz":
				case "timestamp without time zone":
				case "timestamp with time zone":
					return "DateTime";
				case "time":
				case "timetz":
				case "time without time zone":
				case "time with time zone":
					return "TimeSpan";
				// 布尔类型
				case "bool":
				case "boolean":
					return "bool";
				case "uuid":
					return "Guid";
				default:
					return "object";
			}
		}
	}
}