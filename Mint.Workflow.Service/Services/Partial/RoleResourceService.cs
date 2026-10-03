/*
 *Author：杨工子
 *Contact：YangGongzi@163.com
 *Website：https://www.yanggongzi.dev
 *此文件代码由框架生成器生成,任何更改都可能导致被代码生成器覆盖
 *所有自定义业务代码都应在 非Partial 文件夹下的RoleResourceService.cs中编写
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
///  角色资源关联模块Service类
/// </summary>
public partial class RoleResourceService {

    /// <summary>
    /// 添加角色资源关联模块
    /// </summary>
    /// <param name="RoleResource"></param>
    /// <returns></returns>
    public async Task<bool> AddRoleResourceAsync(RoleResource roleresource) {
        return await _dbContext.RoleResourceRepository.InsertAsync(roleresource);
    }

    /// <summary>
    ///  删除角色资源关联模块
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public async Task<bool> DeleteRoleResourceAsync(long id) {
        var entity = await _dbContext.RoleResourceRepository.FindByIdAsync(id);
        if (entity == null) {
            return false;
        }
        return await _dbContext.RoleResourceRepository.DeleteAsync(entity);
    }

    /// <summary>
    ///  根据id获取角色资源关联模块详情
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public async Task<RoleResource> GetRoleResourceByIdAsync(long id) {
        // 查询角色资源关联模块数据
        return await _dbContext.RoleResourceRepository.FindByIdAsync(id);
    }

    /// <summary>
    ///  修改角色资源关联模块
    /// </summary>
    /// <param name="RoleResource"></param>
    /// <returns></returns>
    public async Task<bool> UpdateRoleResourceAsync(RoleResource roleresource) {
        return await _dbContext.RoleResourceRepository.UpdateAsync(roleresource);
    }
    
}
