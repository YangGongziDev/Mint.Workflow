/*
 *Author：杨工子
 *Contact：YangGongzi@163.com
 *Website：https://www.yanggongzi.dev
 *此文件代码由框架生成器生成,任何更改都可能导致被代码生成器覆盖
 *所有自定义业务代码都应在 非Partial 文件夹下的ResourceService.cs中编写
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
///  资源（菜单）模块Service类
/// </summary>
public partial class ResourceService {

    /// <summary>
    /// 添加资源（菜单）模块
    /// </summary>
    /// <param name="Resource"></param>
    /// <returns></returns>
    public async Task<bool> AddResourceAsync(Resource resource) {
        return await _dbContext.ResourceRepository.InsertAsync(resource);
    }

    /// <summary>
    ///  删除资源（菜单）模块
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public async Task<bool> DeleteResourceAsync(long id) {
        var entity = await _dbContext.ResourceRepository.FindByIdAsync(id);
        if (entity == null) {
            return false;
        }
        return await _dbContext.ResourceRepository.DeleteAsync(entity);
    }

    /// <summary>
    ///  根据id获取资源（菜单）模块详情
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public async Task<Resource> GetResourceByIdAsync(long id) {
        // 查询资源（菜单）模块数据
        return await _dbContext.ResourceRepository.FindByIdAsync(id);
    }

    /// <summary>
    ///  修改资源（菜单）模块
    /// </summary>
    /// <param name="Resource"></param>
    /// <returns></returns>
    public async Task<bool> UpdateResourceAsync(Resource resource) {
        return await _dbContext.ResourceRepository.UpdateAsync(resource);
    }
    
}
