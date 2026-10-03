using System.Collections.Generic;

namespace Mint.Workflow.Generator {
	/// <summary>
	/// 数据表映射元数据
	/// </summary>
	public class TableMapMetadata {
		public string ClassName { get; set; }
		public string TableComment { get; set; }
		public string TableName { get; set; }
		public List<PropertyMapMetadata> Properties { get; set; }
		public PropertyMapMetadata PrimaryKey { get; set; }
	}

	/// <summary>
	/// 属性映射元数据
	/// </summary>
	public class PropertyMapMetadata {
		public string PropertyName { get; set; }
		public string PropertyType { get; set; }
		public string? PropertyComment { get; set; }
		public bool IsPrimaryKey { get; set; } // 是否为主键
		public bool IsIdentity { get; set; }   // 是否为自增列
	}
}