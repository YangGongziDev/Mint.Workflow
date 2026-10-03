/*
 *Author：杨工子
 *Contact：YangGongzi@163.com
 *Website：https://www.yanggongzi.dev
 *此文件代码由框架生成器生成,任何更改都可能导致被代码生成器覆盖
 *所有自定义业务代码都应在 非Partial 文件夹下的IWorkflowUrgeService.cs中编写
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
/// 流程催办模块IService接口
/// </summary>
public partial interface IWorkflowUrgeService {

    /// <summary>
    /// 添加流程催办模块
    /// </summary>
    /// <param name="WorkflowUrge"></param>
    /// <returns></returns>
    Task<bool> AddWorkflowUrgeAsync(WorkflowUrge workflowurge);

    /// <summary>
    /// 删除流程催办模块
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    Task<bool> DeleteWorkflowUrgeAsync(string id);

    /// <summary>
    ///  修改流程催办模块
    /// </summary>
    /// <param name="WorkflowUrge"></param>
    /// <returns></returns>
    Task<bool> UpdateWorkflowUrgeAsync(WorkflowUrge workflowurge);

    /// <summary>
    /// 根据Id获取流程催办模块信息详情
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    Task<WorkflowUrge> GetWorkflowUrgeByIdAsync(string id);
    
}
