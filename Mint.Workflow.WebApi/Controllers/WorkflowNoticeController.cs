/*
 *Author：杨工子
 *Contact：YangGongzi@163.com
 *Website：https://www.yanggongzi.dev
 *所有关于WorkflowNoticeController自定义的业务代码应在此处编写
 *由框架生成器生成的部分通用功能在Partial\WorkflowNoticeController.cs中
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
/// 流程通知节点模块控制器
/// </summary>
[Route("api/[controller]")]
[ApiController]
public partial class WorkflowNoticeController : BaseController<WorkflowNoticeController> {

    private IWorkflowNoticeService _workflownoticeService;

    public WorkflowNoticeController(ILogger<WorkflowNoticeController> logger, IWorkflowNoticeService workflownoticeService) : base(logger) {
        _workflownoticeService = workflownoticeService;
    }

    /// <summary>
    /// 
    /// </summary>

}
