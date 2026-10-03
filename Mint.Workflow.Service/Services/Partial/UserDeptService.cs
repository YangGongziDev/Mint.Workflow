/*
 *Author：杨工子
 *Contact：YangGongzi@163.com
 *Website：https://www.yanggongzi.dev
 *此文件代码由框架生成器生成,任何更改都可能导致被代码生成器覆盖
 *所有自定义业务代码都应在 非Partial 文件夹下的UserDeptService.cs中编写
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
///  用户部门关联模块Service类
/// </summary>
public partial class UserDeptService {

    /// <summary>
    /// 添加用户部门关联模块
    /// </summary>
    /// <param name="UserDept"></param>
    /// <returns></returns>
    public async Task<bool> AddUserDeptAsync(UserDept userdept) {
        return await _dbContext.UserDeptRepository.InsertAsync(userdept);
    }

    /// <summary>
    ///  删除用户部门关联模块
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public async Task<bool> DeleteUserDeptAsync(long id) {
        var entity = await _dbContext.UserDeptRepository.FindByIdAsync(id);
        if (entity == null) {
            return false;
        }
        return await _dbContext.UserDeptRepository.DeleteAsync(entity);
    }

    /// <summary>
    ///  根据id获取用户部门关联模块详情
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public async Task<UserDept> GetUserDeptByIdAsync(long id) {
        // 查询用户部门关联模块数据
        return await _dbContext.UserDeptRepository.FindByIdAsync(id);
    }

    /// <summary>
    ///  修改用户部门关联模块
    /// </summary>
    /// <param name="UserDept"></param>
    /// <returns></returns>
    public async Task<bool> UpdateUserDeptAsync(UserDept userdept) {
        return await _dbContext.UserDeptRepository.UpdateAsync(userdept);
    }
    
}
