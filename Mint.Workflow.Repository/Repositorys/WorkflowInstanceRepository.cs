/*
 *Author：杨工子
 *Contact：YangGongzi@163.com
 *Website：https://www.yanggongzi.dev
 *所有关于WorkflowInstanceRepository自定义的业务代码应在此处编写
 *由框架生成器生成的部分通用功能在Partial\WorkflowInstanceRepository.cs中
*/

using JadeFramework.Dapper;
using JadeFramework.Dapper.SqlGenerator;
using Mint.Workflow.Entity.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mint.Workflow.Repository.IRepositorys;
using Mint.Workflow.Common.Exception;
using Mint.Workflow.Entity.Dtos;
using Mint.Workflow.Entity.Vos;

namespace Mint.Workflow.Repository.Repositorys;

/// <summary>
/// 流程实例模块（运行中的流程）
/// </summary>
public partial class WorkflowInstanceRepository : DapperRepository<WorkflowInstance>, IWorkflowInstanceRepository {

    /// <summary>
    /// 1.IDbConnection Dapper实现数据库操作,连接对象
    /// 2.SqlGeneratorConfig 配置数据库类型PostgreSQL
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="config"></param>
    public WorkflowInstanceRepository(IDbConnection connection, SqlGeneratorConfig config) : base(connection, config) {
    
    /// <summary>
    /// 
    /// </summary>
        
    }
}