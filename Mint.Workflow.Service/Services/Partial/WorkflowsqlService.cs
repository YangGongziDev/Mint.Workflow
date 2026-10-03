/*
 *Author：杨工子
 *Contact：YangGongzi@163.com
 *Website：https://www.yanggongzi.dev
 *此文件代码由框架生成器生成,任何更改都可能导致被代码生成器覆盖
 *所有自定义业务代码都应在 非Partial 文件夹下的WorkflowsqlService.cs中编写
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
///  流程外部SQL权限模块Service类
/// </summary>
public partial class WorkflowsqlService {

    /// <summary>
    /// 添加流程外部SQL权限模块
    /// </summary>
    /// <param name="Workflowsql"></param>
    /// <returns></returns>
    public async Task<bool> AddWorkflowsqlAsync(Workflowsql workflowsql) {
        return await _dbContext.WorkflowsqlRepository.InsertAsync(workflowsql);
    }

    /// <summary>
    ///  删除流程外部SQL权限模块
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public async Task<bool> DeleteWorkflowsqlAsync(string id) {
        var entity = await _dbContext.WorkflowsqlRepository.FindByIdAsync(id);
        if (entity == null) {
            return false;
        }
        return await _dbContext.WorkflowsqlRepository.DeleteAsync(entity);
    }

    /// <summary>
    ///  根据id获取流程外部SQL权限模块详情
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public async Task<Workflowsql> GetWorkflowsqlByIdAsync(string id) {
        // 查询流程外部SQL权限模块数据
        return await _dbContext.WorkflowsqlRepository.FindByIdAsync(id);
    }

    /// <summary>
    ///  修改流程外部SQL权限模块
    /// </summary>
    /// <param name="Workflowsql"></param>
    /// <returns></returns>
    public async Task<bool> UpdateWorkflowsqlAsync(Workflowsql workflowsql) {
        return await _dbContext.WorkflowsqlRepository.UpdateAsync(workflowsql);
    }
    
}
