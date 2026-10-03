/*
 *Author：杨工子
 *Contact：YangGongzi@163.com
 *Website：https://www.yanggongzi.dev
 *此文件代码由框架生成器生成,任何更改都可能导致被代码生成器覆盖
 *所有自定义业务代码都应在 非Partial 文件夹下的RoleService.cs中编写
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
///  角色模块Service类
/// </summary>
public partial class RoleService {

    /// <summary>
    /// 添加角色模块
    /// </summary>
    /// <param name="Role"></param>
    /// <returns></returns>
    public async Task<bool> AddRoleAsync(Role role) {
        return await _dbContext.RoleRepository.InsertAsync(role);
    }

    /// <summary>
    ///  删除角色模块
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public async Task<bool> DeleteRoleAsync(long id) {
        var entity = await _dbContext.RoleRepository.FindByIdAsync(id);
        if (entity == null) {
            return false;
        }
        return await _dbContext.RoleRepository.DeleteAsync(entity);
    }

    /// <summary>
    ///  根据id获取角色模块详情
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public async Task<Role> GetRoleByIdAsync(long id) {
        // 查询角色模块数据
        return await _dbContext.RoleRepository.FindByIdAsync(id);
    }

    /// <summary>
    ///  修改角色模块
    /// </summary>
    /// <param name="Role"></param>
    /// <returns></returns>
    public async Task<bool> UpdateRoleAsync(Role role) {
        return await _dbContext.RoleRepository.UpdateAsync(role);
    }
    
}
