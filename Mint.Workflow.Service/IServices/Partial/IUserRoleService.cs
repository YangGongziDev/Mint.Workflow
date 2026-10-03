/*
 *Author：杨工子
 *Contact：YangGongzi@163.com
 *Website：https://www.yanggongzi.dev
 *此文件代码由框架生成器生成,任何更改都可能导致被代码生成器覆盖
 *所有自定义业务代码都应在 非Partial 文件夹下的IUserRoleService.cs中编写
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
/// 用户角色关联模块IService接口
/// </summary>
public partial interface IUserRoleService {

    /// <summary>
    /// 添加用户角色关联模块
    /// </summary>
    /// <param name="UserRole"></param>
    /// <returns></returns>
    Task<bool> AddUserRoleAsync(UserRole userrole);

    /// <summary>
    /// 删除用户角色关联模块
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    Task<bool> DeleteUserRoleAsync(long id);

    /// <summary>
    ///  修改用户角色关联模块
    /// </summary>
    /// <param name="UserRole"></param>
    /// <returns></returns>
    Task<bool> UpdateUserRoleAsync(UserRole userrole);

    /// <summary>
    /// 根据Id获取用户角色关联模块信息详情
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    Task<UserRole> GetUserRoleByIdAsync(long id);
    
}
