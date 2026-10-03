/*
 *Author：杨工子
 *Contact：YangGongzi@163.com
 *Website：https://www.yanggongzi.dev
 *此文件代码由框架生成器生成,任何更改都可能导致被代码生成器覆盖
 *所有自定义业务代码都应在 非Partial 文件夹下的WorkflowService.cs中编写
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
///  流程定义模块Service类
/// </summary>
public partial class WorkflowService {

    /// <summary>
    /// 添加流程定义模块
    /// </summary>
    /// <param name="Workflow"></param>
    /// <returns></returns>
    public async Task<bool> AddWorkflowAsync(Entity.Models.Workflow workflow) {
        return await _dbContext.WorkflowRepository.InsertAsync(workflow);
    }

    /// <summary>
    ///  删除流程定义模块
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public async Task<bool> DeleteWorkflowAsync(string id) {
        var entity = await _dbContext.WorkflowRepository.FindByIdAsync(id);
        if (entity == null) {
            return false;
        }
        return await _dbContext.WorkflowRepository.DeleteAsync(entity);
    }

    /// <summary>
    ///  根据id获取流程定义模块详情
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public async Task<Entity.Models.Workflow> GetWorkflowByIdAsync(string id) {
        // 查询流程定义模块数据
        return await _dbContext.WorkflowRepository.FindByIdAsync(id);
    }

    /// <summary>
    ///  修改流程定义模块
    /// </summary>
    /// <param name="Workflow"></param>
    /// <returns></returns>
    public async Task<bool> UpdateWorkflowAsync(Entity.Models.Workflow workflow) {
        return await _dbContext.WorkflowRepository.UpdateAsync(workflow);
    }
    
}
