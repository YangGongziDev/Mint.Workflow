/*
 *Author：杨工子
 *Contact：YangGongzi@163.com
 *Website：https://www.yanggongzi.dev
 *所有关于WorkflowUrgeController自定义的业务代码应在此处编写
 *由框架生成器生成的部分通用功能在Partial\WorkflowUrgeController.cs中
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
/// 流程催办模块控制器
/// </summary>
[Route("api/[controller]")]
[ApiController]
public partial class WorkflowUrgeController : BaseController<WorkflowUrgeController> {

    private IWorkflowUrgeService _workflowurgeService;

    public WorkflowUrgeController(ILogger<WorkflowUrgeController> logger, IWorkflowUrgeService workflowurgeService) : base(logger) {
        _workflowurgeService = workflowurgeService;
    }

    /// <summary>
    /// 
    /// </summary>

}
