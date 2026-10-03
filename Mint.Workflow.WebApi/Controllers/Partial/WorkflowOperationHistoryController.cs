/*
 *Author：杨工子
 *Contact：YangGongzi@163.com
 *Website：https://www.yanggongzi.dev
 *此文件代码由框架生成器生成,任何更改都可能导致被代码生成器覆盖
 *所有自定义业务代码都应在 非Partial 文件夹下的WorkflowOperationHistoryController.cs中编写
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
/// 流程操作历史模块控制器
/// </summary>
public partial class WorkflowOperationHistoryController {

    /// <summary>
    /// 添加流程操作历史模块
    /// </summary>
    /// <param name="workflowoperationhistory"></param>
    [HttpPost]
    public async Task<IActionResult> PostAsync([FromBody] WorkflowOperationHistory workflowoperationhistory) {
        var result = await _workflowoperationhistoryService.AddWorkflowOperationHistoryAsync(workflowoperationhistory);
        return result ? StatusCode(StatusCodes.Status201Created) : BadRequest();
    }

    /// <summary>
    ///  删除流程操作历史模块
    /// </summary>
    /// <param name="id"></param>
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAsync([FromRoute] string id) {
        var result = await _workflowoperationhistoryService.DeleteWorkflowOperationHistoryAsync(id);
        return result ? NoContent() : NotFound();
    }

    /// <summary>
    /// 修改流程操作历史模块信息
    /// </summary>
    /// <param name="id"></param>
    /// <param name="workflowoperationhistory"></param>
    [HttpPut("{id}")]
    public async Task<IActionResult> PutAsync([FromRoute] string id, [FromBody] WorkflowOperationHistory workflowoperationhistory) {
        if (!EqualityComparer<string>.Default.Equals(id, workflowoperationhistory.OperationId)) {
            return BadRequest();
        }
        var result = await _workflowoperationhistoryService.UpdateWorkflowOperationHistoryAsync(workflowoperationhistory);
        return result ? NoContent() : NotFound();
    }

    /// <summary>
    /// 获取流程操作历史模块信息
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    [HttpGet("{id}")]
    public async Task<ActionResult<WorkflowOperationHistory>> GetAsync([FromRoute] string id) {
        var entity = await _workflowoperationhistoryService.GetWorkflowOperationHistoryByIdAsync(id);
        return entity == null ? NotFound() : Ok(entity);
    }

}
