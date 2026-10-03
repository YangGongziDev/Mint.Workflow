/*
 *Author：杨工子
 *Contact：YangGongzi@163.com
 *Website：https://www.yanggongzi.dev
 *此文件代码由框架生成器生成,任何更改都可能导致被代码生成器覆盖
 *所有自定义业务代码都应在 非Partial 文件夹下的WorkflowFormController.cs中编写
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
/// 流程表单模块控制器
/// </summary>
public partial class WorkflowFormController {

    /// <summary>
    /// 添加流程表单模块
    /// </summary>
    /// <param name="workflowform"></param>
    [HttpPost]
    public async Task<IActionResult> PostAsync([FromBody] WorkflowForm workflowform) {
        var result = await _workflowformService.AddWorkflowFormAsync(workflowform);
        return result ? StatusCode(StatusCodes.Status201Created) : BadRequest();
    }

    /// <summary>
    ///  删除流程表单模块
    /// </summary>
    /// <param name="id"></param>
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAsync([FromRoute] string id) {
        var result = await _workflowformService.DeleteWorkflowFormAsync(id);
        return result ? NoContent() : NotFound();
    }

    /// <summary>
    /// 修改流程表单模块信息
    /// </summary>
    /// <param name="id"></param>
    /// <param name="workflowform"></param>
    [HttpPut("{id}")]
    public async Task<IActionResult> PutAsync([FromRoute] string id, [FromBody] WorkflowForm workflowform) {
        if (!EqualityComparer<string>.Default.Equals(id, workflowform.FormId)) {
            return BadRequest();
        }
        var result = await _workflowformService.UpdateWorkflowFormAsync(workflowform);
        return result ? NoContent() : NotFound();
    }

    /// <summary>
    /// 获取流程表单模块信息
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    [HttpGet("{id}")]
    public async Task<ActionResult<WorkflowForm>> GetAsync([FromRoute] string id) {
        var entity = await _workflowformService.GetWorkflowFormByIdAsync(id);
        return entity == null ? NotFound() : Ok(entity);
    }

}
