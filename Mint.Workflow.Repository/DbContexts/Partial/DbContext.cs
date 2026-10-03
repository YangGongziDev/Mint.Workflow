/*
 *Author：杨工子
 *Contact：YangGongzi@163.com
 *Website：https://www.yanggongzi.dev
 *此文件代码由框架生成器生成,任何更改都可能导致被代码生成器覆盖
 *所有自定义业务代码都应在 非Partial 文件夹下的DbContext.cs中编写
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
public partial class DbContext {

    /// <summary>
    /// 实现用户仓储
    /// </summary>
	public IDeptRepository DeptRepository => new DeptRepository(Connection,sqlGeneratorConfig);
	public IResourceRepository ResourceRepository => new ResourceRepository(Connection,sqlGeneratorConfig);
	public IRoleRepository RoleRepository => new RoleRepository(Connection,sqlGeneratorConfig);
	public IRoleResourceRepository RoleResourceRepository => new RoleResourceRepository(Connection,sqlGeneratorConfig);
	public ISystemsRepository SystemsRepository => new SystemsRepository(Connection,sqlGeneratorConfig);
	public IUserRepository UserRepository => new UserRepository(Connection,sqlGeneratorConfig);
	public IUserDeptRepository UserDeptRepository => new UserDeptRepository(Connection,sqlGeneratorConfig);
	public IUserRoleRepository UserRoleRepository => new UserRoleRepository(Connection,sqlGeneratorConfig);
	public IWorkflowRepository WorkflowRepository => new WorkflowRepository(Connection,sqlGeneratorConfig);
	public IWorkflowAssignRepository WorkflowAssignRepository => new WorkflowAssignRepository(Connection,sqlGeneratorConfig);
	public IWorkflowCategoryRepository WorkflowCategoryRepository => new WorkflowCategoryRepository(Connection,sqlGeneratorConfig);
	public IWorkflowFormRepository WorkflowFormRepository => new WorkflowFormRepository(Connection,sqlGeneratorConfig);
	public IWorkflowInstanceRepository WorkflowInstanceRepository => new WorkflowInstanceRepository(Connection,sqlGeneratorConfig);
	public IWorkflowInstanceFormRepository WorkflowInstanceFormRepository => new WorkflowInstanceFormRepository(Connection,sqlGeneratorConfig);
	public IWorkflowNoticeRepository WorkflowNoticeRepository => new WorkflowNoticeRepository(Connection,sqlGeneratorConfig);
	public IWorkflowOperationHistoryRepository WorkflowOperationHistoryRepository => new WorkflowOperationHistoryRepository(Connection,sqlGeneratorConfig);
	public IWorkflowTransitionHistoryRepository WorkflowTransitionHistoryRepository => new WorkflowTransitionHistoryRepository(Connection,sqlGeneratorConfig);
	public IWorkflowUrgeRepository WorkflowUrgeRepository => new WorkflowUrgeRepository(Connection,sqlGeneratorConfig);
	public IWorkflowsqlRepository WorkflowsqlRepository => new WorkflowsqlRepository(Connection,sqlGeneratorConfig);
}