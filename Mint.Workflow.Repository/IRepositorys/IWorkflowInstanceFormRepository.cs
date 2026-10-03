/*
 *Author：杨工子
 *Contact：YangGongzi@163.com
 *Website：https://www.yanggongzi.dev
 *所有关于IWorkflowInstanceFormRepository自定义的业务代码应在此处编写
 *由框架生成器生成的部分通用功能在Partial\IWorkflowInstanceFormRepository.cs中
*/

using JadeFramework.Dapper;
using Mint.Workflow.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mint.Workflow.Common.Exception;
using Mint.Workflow.Entity.Dtos;
using Mint.Workflow.Entity.Vos;

namespace Mint.Workflow.Repository.IRepositorys;

/// <summary>
/// 流程实例表单数据模块
/// </summary>
public partial interface IWorkflowInstanceFormRepository : IDapperRepository<WorkflowInstanceForm> {

    /// <summary>
    /// 
    /// </summary>

}