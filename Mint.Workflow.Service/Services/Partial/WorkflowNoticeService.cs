/*
 *Author：杨工子
 *Contact：YangGongzi@163.com
 *Website：https://www.yanggongzi.dev
 *此文件代码由框架生成器生成,任何更改都可能导致被代码生成器覆盖
 *所有自定义业务代码都应在 非Partial 文件夹下的WorkflowNoticeService.cs中编写
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Mint.Workflow.Entity.Models;
using Mint.Workflow.Repository.DbContexts;
using Mint.Workflow.Repository.IDbContexts;
using Mint.Workflow.Service.IServices;
using Mint.Workflow.Entity.Dtos;
using Mint.Workflow.Entity.Vos;
using Mint.Workflow.Common.Exception;
using JadeFramework.Core.Extensions;

namespace Mint.Workflow.Service.Services;

/// <summary>
///  流程通知节点模块Service类
/// </summary>
public partial class WorkflowNoticeService {

    /// <summary>
    /// 添加流程通知节点模块
    /// </summary>
    /// <param name="WorkflowNotice"></param>
    /// <returns></returns>
    public async Task<bool> AddWorkflowNoticeAsync(WorkflowNotice workflownotice) {
        return await _dbContext.WorkflowNoticeRepository.InsertAsync(workflownotice);
    }

    /// <summary>
    ///  删除流程通知节点模块
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public async Task<bool> DeleteWorkflowNoticeAsync(string id) {
        var entity = await _dbContext.WorkflowNoticeRepository.FindByIdAsync(id);
        if (entity == null) {
            return false;
        }
        return await _dbContext.WorkflowNoticeRepository.DeleteAsync(entity);
    }

    /// <summary>
    ///  根据id获取流程通知节点模块详情
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public async Task<WorkflowNotice> GetWorkflowNoticeByIdAsync(string id) {
        // 查询流程通知节点模块数据
        return await _dbContext.WorkflowNoticeRepository.FindByIdAsync(id);
    }

    /// <summary>
    ///  修改流程通知节点模块
    /// </summary>
    /// <param name="WorkflowNotice"></param>
    /// <returns></returns>
    public async Task<bool> UpdateWorkflowNoticeAsync(WorkflowNotice workflownotice) {
        return await _dbContext.WorkflowNoticeRepository.UpdateAsync(workflownotice);
    }
    
}
