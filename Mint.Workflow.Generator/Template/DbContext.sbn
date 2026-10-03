/*
 *Author：杨工子
 *Contact：YangGongzi@163.com
 *Website：https://www.yanggongzi.dev
 *所有关于DbContext自定义的业务代码应在此处编写
 *由框架生成器生成的部分通用功能在Partial\DbContext.cs中
*/

using DapperExtensions.Sql;
using JadeFramework.Dapper.DbContext;
using JadeFramework.Dapper.SqlGenerator;
using Microsoft.Extensions.Configuration;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mint.Workflow.Repository.IDbContexts;
using Mint.Workflow.Repository.IRepositorys;
using Mint.Workflow.Repository.Repositorys;
using Mint.Workflow.Common.Exception;

namespace Mint.Workflow.Repository.DbContexts;

/// <summary>
/// 工作流上下文实现类
/// </summary>
public partial class DbContext : DapperDbContext, IDbContext {

    /// <summary>
    /// 选择数据库
    /// </summary>
    private readonly SqlGeneratorConfig sqlGeneratorConfig = new SqlGeneratorConfig() {
        SqlConnector = ESqlConnector.PostgreSQL,
        UseQuotationMarks = true,//表和列名使用引号
    };
    
    public DbContext(string ConnectionString) : base(new NpgsqlConnection(ConnectionString)) {
    }
    
    /// <summary>
    /// 
    /// </summary>
    
}