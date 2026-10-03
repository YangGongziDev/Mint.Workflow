/*
 *Author：杨工子
 *Contact：YangGongzi@163.com
 *Website：https://www.yanggongzi.dev
 *此文件代码由框架生成器生成,任何更改都可能导致被代码生成器覆盖
 *所有自定义业务代码都应在 非Partial 文件夹下的IWorkflowNoticeService.cs中编写
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
/// 流程通知节点模块IService接口
/// </summary>
public partial interface IWorkflowNoticeService {

    /// <summary>
    /// 添加流程通知节点模块
    /// </summary>
    /// <param name="WorkflowNotice"></param>
    /// <returns></returns>
    Task<bool> AddWorkflowNoticeAsync(WorkflowNotice workflownotice);

    /// <summary>
    /// 删除流程通知节点模块
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    Task<bool> DeleteWorkflowNoticeAsync(string id);

    /// <summary>
    ///  修改流程通知节点模块
    /// </summary>
    /// <param name="WorkflowNotice"></param>
    /// <returns></returns>
    Task<bool> UpdateWorkflowNoticeAsync(WorkflowNotice workflownotice);

    /// <summary>
    /// 根据Id获取流程通知节点模块信息详情
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    Task<WorkflowNotice> GetWorkflowNoticeByIdAsync(string id);
    
}
