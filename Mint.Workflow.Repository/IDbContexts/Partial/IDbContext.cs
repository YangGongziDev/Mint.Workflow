/*
 *Author：杨工子
 *Contact：YangGongzi@163.com
 *Website：https://www.yanggongzi.dev
 *此文件代码由框架生成器生成,任何更改都可能导致被代码生成器覆盖
 *所有自定义业务代码都应在 非Partial 文件夹下的IDbContext.cs中编写
*/

using JadeFramework.Dapper.DbContext;
using Mint.Workflow.Repository.IRepositorys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mint.Workflow.Common.Exception;

namespace Mint.Workflow.Repository.IDbContexts;

/// <summary>
/// 工作流上下文接口
/// </summary>  
public partial interface IDbContext {

    // 依赖IxxRepository
	public IDeptRepository DeptRepository { get; }
	public IResourceRepository ResourceRepository { get; }
	public IRoleRepository RoleRepository { get; }
	public IRoleResourceRepository RoleResourceRepository { get; }
	public ISystemsRepository SystemsRepository { get; }
	public IUserRepository UserRepository { get; }
	public IUserDeptRepository UserDeptRepository { get; }
	public IUserRoleRepository UserRoleRepository { get; }
	public IWorkflowRepository WorkflowRepository { get; }
	public IWorkflowAssignRepository WorkflowAssignRepository { get; }
	public IWorkflowCategoryRepository WorkflowCategoryRepository { get; }
	public IWorkflowFormRepository WorkflowFormRepository { get; }
	public IWorkflowInstanceRepository WorkflowInstanceRepository { get; }
	public IWorkflowInstanceFormRepository WorkflowInstanceFormRepository { get; }
	public IWorkflowNoticeRepository WorkflowNoticeRepository { get; }
	public IWorkflowOperationHistoryRepository WorkflowOperationHistoryRepository { get; }
	public IWorkflowTransitionHistoryRepository WorkflowTransitionHistoryRepository { get; }
	public IWorkflowUrgeRepository WorkflowUrgeRepository { get; }
	public IWorkflowsqlRepository WorkflowsqlRepository { get; }
}