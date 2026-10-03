/*
 *Author：杨工子
 *Contact：YangGongzi@163.com
 *Website：https://www.yanggongzi.dev
 *所有关于IUserService自定义的业务代码应在此处编写
 *由框架生成器生成的部分通用功能在Partial\IUserService.cs中
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mint.Workflow.Entity.Models;
using Mint.Workflow.Entity.Dtos;
using Mint.Workflow.Entity.Vos;
using Mint.Workflow.Common.Exception;

namespace Mint.Workflow.Service.IServices;

/// <summary>
/// 用户模块IService接口
/// </summary>
public partial interface IUserService {

	/// <summary>
	/// 用户登录
	/// </summary>
	public Task<UserLoginVo> LoginAsync(UserLoginDto request);
    
}
