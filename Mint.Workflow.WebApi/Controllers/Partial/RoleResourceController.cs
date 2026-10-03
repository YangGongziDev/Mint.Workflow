/*
 *Author：杨工子
 *Contact：YangGongzi@163.com
 *Website：https://www.yanggongzi.dev
 *此文件代码由框架生成器生成,任何更改都可能导致被代码生成器覆盖
 *所有自定义业务代码都应在 非Partial 文件夹下的RoleResourceController.cs中编写
*/
 
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mint.Workflow.Common.Controller;
using Microsoft.Extensions.Logging;
using Mint.Workflow.Entity.Models;
using Mint.Workflow.Entity.Dtos;
using Mint.Workflow.Entity.Vos;
using Mint.Workflow.Service.IServices;
using Mint.Workflow.Service.Services;
using Mint.Workflow.Common.Exception;
using Mint.Workflow.Common.Result;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Newtonsoft.Json;
using System.Security.Claims;

namespace Mint.Workflow.WebApi.Controllers;

/// <summary>
/// 角色资源关联模块控制器
/// </summary>
public partial class RoleResourceController {

    /// <summary>
    /// 添加角色资源关联模块
    /// </summary>
    /// <param name="roleresource"></param>
    [HttpPost]
    public async Task<IActionResult> PostAsync([FromBody] RoleResource roleresource) {
        var result = await _roleresourceService.AddRoleResourceAsync(roleresource);
        return result ? StatusCode(StatusCodes.Status201Created) : BadRequest();
    }

    /// <summary>
    ///  删除角色资源关联模块
    /// </summary>
    /// <param name="id"></param>
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAsync([FromRoute] long id) {
        var result = await _roleresourceService.DeleteRoleResourceAsync(id);
        return result ? NoContent() : NotFound();
    }

    /// <summary>
    /// 修改角色资源关联模块信息
    /// </summary>
    /// <param name="id"></param>
    /// <param name="roleresource"></param>
    [HttpPut("{id}")]
    public async Task<IActionResult> PutAsync([FromRoute] long id, [FromBody] RoleResource roleresource) {
        if (!EqualityComparer<long>.Default.Equals(id, roleresource.Id)) {
            return BadRequest();
        }
        var result = await _roleresourceService.UpdateRoleResourceAsync(roleresource);
        return result ? NoContent() : NotFound();
    }

    /// <summary>
    /// 获取角色资源关联模块信息
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    [HttpGet("{id}")]
    public async Task<ActionResult<RoleResource>> GetAsync([FromRoute] long id) {
        var entity = await _roleresourceService.GetRoleResourceByIdAsync(id);
        return entity == null ? NotFound() : Ok(entity);
    }

}
