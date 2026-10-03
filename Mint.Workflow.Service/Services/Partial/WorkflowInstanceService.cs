/*
 *Author：杨工子
 *Contact：YangGongzi@163.com
 *Website：https://www.yanggongzi.dev
 *此文件代码由框架生成器生成,任何更改都可能导致被代码生成器覆盖
 *所有自定义业务代码都应在 非Partial 文件夹下的WorkflowInstanceService.cs中编写
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
///  流程实例模块（运行中的流程）Service类
/// </summary>
public partial class WorkflowInstanceService {

    /// <summary>
    /// 添加流程实例模块（运行中的流程）
    /// </summary>
    /// <param name="WorkflowInstance"></param>
    /// <returns></returns>
    public async Task<bool> AddWorkflowInstanceAsync(WorkflowInstance workflowinstance) {
        return await _dbContext.WorkflowInstanceRepository.InsertAsync(workflowinstance);
    }

    /// <summary>
    ///  删除流程实例模块（运行中的流程）
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public async Task<bool> DeleteWorkflowInstanceAsync(string id) {
        var entity = await _dbContext.WorkflowInstanceRepository.FindByIdAsync(id);
        if (entity == null) {
            return false;
        }
        return await _dbContext.WorkflowInstanceRepository.DeleteAsync(entity);
    }

    /// <summary>
    ///  根据id获取流程实例模块（运行中的流程）详情
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public async Task<WorkflowInstance> GetWorkflowInstanceByIdAsync(string id) {
        // 查询流程实例模块（运行中的流程）数据
        return await _dbContext.WorkflowInstanceRepository.FindByIdAsync(id);
    }

    /// <summary>
    ///  修改流程实例模块（运行中的流程）
    /// </summary>
    /// <param name="WorkflowInstance"></param>
    /// <returns></returns>
    public async Task<bool> UpdateWorkflowInstanceAsync(WorkflowInstance workflowinstance) {
        return await _dbContext.WorkflowInstanceRepository.UpdateAsync(workflowinstance);
    }
    
}
