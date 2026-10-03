/*
 *Author：杨工子
 *Contact：YangGongzi@163.com
 *Website：https://www.yanggongzi.dev
 *此文件代码由框架生成器生成,任何更改都可能导致被代码生成器覆盖
 *所有自定义业务代码都应在 非Partial 文件夹下的WorkflowCategoryController.cs中编写
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
/// 流程分类模块控制器
/// </summary>
public partial class WorkflowCategoryController {

    /// <summary>
    /// 添加流程分类模块
    /// </summary>
    /// <param name="workflowcategory"></param>
    [HttpPost]
    public async Task<IActionResult> PostAsync([FromBody] WorkflowCategory workflowcategory) {
        var result = await _workflowcategoryService.AddWorkflowCategoryAsync(workflowcategory);
        return result ? StatusCode(StatusCodes.Status201Created) : BadRequest();
    }

    /// <summary>
    ///  删除流程分类模块
    /// </summary>
    /// <param name="id"></param>
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAsync([FromRoute] string id) {
        var result = await _workflowcategoryService.DeleteWorkflowCategoryAsync(id);
        return result ? NoContent() : NotFound();
    }

    /// <summary>
    /// 修改流程分类模块信息
    /// </summary>
    /// <param name="id"></param>
    /// <param name="workflowcategory"></param>
    [HttpPut("{id}")]
    public async Task<IActionResult> PutAsync([FromRoute] string id, [FromBody] WorkflowCategory workflowcategory) {
        if (!EqualityComparer<string>.Default.Equals(id, workflowcategory.CategoryId)) {
            return BadRequest();
        }
        var result = await _workflowcategoryService.UpdateWorkflowCategoryAsync(workflowcategory);
        return result ? NoContent() : NotFound();
    }

    /// <summary>
    /// 获取流程分类模块信息
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    [HttpGet("{id}")]
    public async Task<ActionResult<WorkflowCategory>> GetAsync([FromRoute] string id) {
        var entity = await _workflowcategoryService.GetWorkflowCategoryByIdAsync(id);
        return entity == null ? NotFound() : Ok(entity);
    }

}
