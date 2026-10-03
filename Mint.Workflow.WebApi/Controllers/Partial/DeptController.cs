/*
 *Author：杨工子
 *Contact：YangGongzi@163.com
 *Website：https://www.yanggongzi.dev
 *此文件代码由框架生成器生成,任何更改都可能导致被代码生成器覆盖
 *所有自定义业务代码都应在 非Partial 文件夹下的DeptController.cs中编写
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
/// 部门模块控制器
/// </summary>
public partial class DeptController {

    /// <summary>
    /// 添加部门模块
    /// </summary>
    /// <param name="dept"></param>
    [HttpPost]
    public async Task<IActionResult> PostAsync([FromBody] Dept dept) {
        var result = await _deptService.AddDeptAsync(dept);
        return result ? StatusCode(StatusCodes.Status201Created) : BadRequest();
    }

    /// <summary>
    ///  删除部门模块
    /// </summary>
    /// <param name="id"></param>
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAsync([FromRoute] long id) {
        var result = await _deptService.DeleteDeptAsync(id);
        return result ? NoContent() : NotFound();
    }

    /// <summary>
    /// 修改部门模块信息
    /// </summary>
    /// <param name="id"></param>
    /// <param name="dept"></param>
    [HttpPut("{id}")]
    public async Task<IActionResult> PutAsync([FromRoute] long id, [FromBody] Dept dept) {
        if (!EqualityComparer<long>.Default.Equals(id, dept.DeptId)) {
            return BadRequest();
        }
        var result = await _deptService.UpdateDeptAsync(dept);
        return result ? NoContent() : NotFound();
    }

    /// <summary>
    /// 获取部门模块信息
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    [HttpGet("{id}")]
    public async Task<ActionResult<Dept>> GetAsync([FromRoute] long id) {
        var entity = await _deptService.GetDeptByIdAsync(id);
        return entity == null ? NotFound() : Ok(entity);
    }

}
