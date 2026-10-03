/*
 *Author：杨工子
 *Contact：YangGongzi@163.com
 *Website：https://www.yanggongzi.dev
 *所有关于UserRoleController自定义的业务代码应在此处编写
 *由框架生成器生成的部分通用功能在Partial\UserRoleController.cs中
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
[Route("api/[controller]")]
[ApiController]
public partial class UserRoleController : BaseController<UserRoleController> {

    private IUserRoleService _userroleService;

    public UserRoleController(ILogger<UserRoleController> logger, IUserRoleService userroleService) : base(logger) {
        _userroleService = userroleService;
    }

    /// <summary>
    /// 
    /// </summary>

}
