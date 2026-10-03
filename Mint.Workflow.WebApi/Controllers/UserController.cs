/*
 *Author：杨工子
 *Contact：YangGongzi@163.com
 *Website：https://www.yanggongzi.dev
 *所有关于UserController自定义的业务代码应在此处编写
 *由框架生成器生成的部分通用功能在Partial\UserController.cs中
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
/// 用户模块控制器
/// </summary>
[Route("api/[controller]")]
[ApiController]
public partial class UserController : BaseController<UserController> {
	private IUserService _userService;

	public UserController(ILogger<UserController> logger, IUserService userService) : base(logger){
		_userService = userService;
	}

	/// <summary>
	/// 用户登录
	/// </summary>
	[HttpPost("Login")]
	public async Task<UserLoginVo> Login(UserLoginDto request){
		// 获取登录结果
		UserLoginVo userLoginDto = await _userService.LoginAsync(request);

		//登录结果存储
		// 1、创建声明
		List<Claim> list = new List<Claim>();
		list.Add(new Claim("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name",
			userLoginDto.UserName));
		list.Add(new Claim("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/gender",
			((int)userLoginDto.Sex).ToString()));
		list.Add(new Claim("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/sid",
			userLoginDto.UserId.ToString()));
		if (!string.IsNullOrEmpty(userLoginDto.HeadImg)) {
			list.Add(new Claim("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/uri",
				userLoginDto.HeadImg));
		}

		if (userLoginDto.Other != null) {
			list.Add(new Claim("http://schemas.microsoft.com/ws/2008/06/identity/claims/userdata",
				JsonConvert.SerializeObject(userLoginDto.Other)));
		}

		// 2、创建用户身份
		ClaimsIdentity identity = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationScheme);
		identity.AddClaims(list);
		// 3、使用Cookie实现登录
		await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(identity));

		return userLoginDto;
	}

	// 获取当前登录用户信息
	[HttpPost("LoggedUserInfo")]
	public async Task<LoggedUserInfoVo> GetLoggedUserInfo(){
		
		if (_userService == null || _loginInfo.UserId <= 0) {
			LoggedUserInfoVo loginInfoVo = new LoggedUserInfoVo();
			loginInfoVo.UserId = -1;
			loginInfoVo.UserName = string.Empty;
			loginInfoVo.CreateTime = null;
			loginInfoVo.HeadImg = string.Empty;
			loginInfoVo.Other = string.Empty;
			loginInfoVo.Sex = null;
			return loginInfoVo;
		}

		return _loginInfo;
	}
	
	// 注销登录
	[HttpGet("Logout")]
	public async Task<UserLoginoutVo> LogoutAsync(){
		await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
		return new UserLoginoutVo();
	}
}