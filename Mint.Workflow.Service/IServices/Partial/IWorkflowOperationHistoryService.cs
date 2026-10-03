/*
 *Author：杨工子
 *Contact：YangGongzi@163.com
 *Website：https://www.yanggongzi.dev
 *此文件代码由框架生成器生成,任何更改都可能导致被代码生成器覆盖
 *所有自定义业务代码都应在 非Partial 文件夹下的IWorkflowOperationHistoryService.cs中编写
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mint.Workflow.Entity.Models;
using Mint.Workflow.Entity.Dtos;
using Mint.Workflow.Entity.Vos;
using Mint.Workflow.Common.Exception;

namespace Mint.Workflow.Service.IServices;

/// <summary>
/// 流程操作历史模块IService接口
/// </summary>
public partial interface IWorkflowOperationHistoryService {

    /// <summary>
    /// 添加流程操作历史模块
    /// </summary>
    /// <param name="WorkflowOperationHistory"></param>
    /// <returns></returns>
    Task<bool> AddWorkflowOperationHistoryAsync(WorkflowOperationHistory workflowoperationhistory);

    /// <summary>
    /// 删除流程操作历史模块
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    Task<bool> DeleteWorkflowOperationHistoryAsync(string id);

    /// <summary>
    ///  修改流程操作历史模块
    /// </summary>
    /// <param name="WorkflowOperationHistory"></param>
    /// <returns></returns>
    Task<bool> UpdateWorkflowOperationHistoryAsync(WorkflowOperationHistory workflowoperationhistory);

    /// <summary>
    /// 根据Id获取流程操作历史模块信息详情
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    Task<WorkflowOperationHistory> GetWorkflowOperationHistoryByIdAsync(string id);
    
}
