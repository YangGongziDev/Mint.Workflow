/*
 *Author：杨工子
 *Contact：YangGongzi@163.com
 *Website：https://www.yanggongzi.dev
 *此文件代码由框架生成器生成,任何更改都可能导致被代码生成器覆盖
 *所有自定义业务代码都应在 非Partial 文件夹下的DeptService.cs中编写
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
///  部门模块Service类
/// </summary>
public partial class DeptService {

    /// <summary>
    /// 添加部门模块
    /// </summary>
    /// <param name="Dept"></param>
    /// <returns></returns>
    public async Task<bool> AddDeptAsync(Dept dept) {
        return await _dbContext.DeptRepository.InsertAsync(dept);
    }

    /// <summary>
    ///  删除部门模块
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public async Task<bool> DeleteDeptAsync(long id) {
        var entity = await _dbContext.DeptRepository.FindByIdAsync(id);
        if (entity == null) {
            return false;
        }
        return await _dbContext.DeptRepository.DeleteAsync(entity);
    }

    /// <summary>
    ///  根据id获取部门模块详情
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public async Task<Dept> GetDeptByIdAsync(long id) {
        // 查询部门模块数据
        return await _dbContext.DeptRepository.FindByIdAsync(id);
    }

    /// <summary>
    ///  修改部门模块
    /// </summary>
    /// <param name="Dept"></param>
    /// <returns></returns>
    public async Task<bool> UpdateDeptAsync(Dept dept) {
        return await _dbContext.DeptRepository.UpdateAsync(dept);
    }
    
}
