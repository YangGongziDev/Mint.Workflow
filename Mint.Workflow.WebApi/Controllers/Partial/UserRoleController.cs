/*
 *Author：杨工子
 *Contact：YangGongzi@163.com
 *Website：https://www.yanggongzi.dev
 *此文件代码由框架生成器生成,任何更改都可能导致被代码生成器覆盖
 *所有自定义业务代码都应在 非Partial 文件夹下的UserRoleController.cs中编写
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
/// 用户角色关联模块控制器
/// </summary>
public partial class UserRoleController {

    /// <summary>
    /// 添加用户角色关联模块
    /// </summary>
    /// <param name="userrole"></param>
    [HttpPost]
    public async Task<IActionResult> PostAsync([FromBody] UserRole userrole) {
        var result = await _userroleService.AddUserRoleAsync(userrole);
        return result ? StatusCode(StatusCodes.Status201Created) : BadRequest();
    }

    /// <summary>
    ///  删除用户角色关联模块
    /// </summary>
    /// <param name="id"></param>
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAsync([FromRoute] long id) {
        var result = await _userroleService.DeleteUserRoleAsync(id);
        return result ? NoContent() : NotFound();
    }

    /// <summary>
    /// 修改用户角色关联模块信息
    /// </summary>
    /// <param name="id"></param>
    /// <param name="userrole"></param>
    [HttpPut("{id}")]
    public async Task<IActionResult> PutAsync([FromRoute] long id, [FromBody] UserRole userrole) {
        if (!EqualityComparer<long>.Default.Equals(id, userrole.Id)) {
            return BadRequest();
        }
        var result = await _userroleService.UpdateUserRoleAsync(userrole);
        return result ? NoContent() : NotFound();
    }

    /// <summary>
    /// 获取用户角色关联模块信息
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    [HttpGet("{id}")]
    public async Task<ActionResult<UserRole>> GetAsync([FromRoute] long id) {
        var entity = await _userroleService.GetUserRoleByIdAsync(id);
        return entity == null ? NotFound() : Ok(entity);
    }

}
