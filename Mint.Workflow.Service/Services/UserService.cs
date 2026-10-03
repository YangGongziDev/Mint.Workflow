/*
 *Author：杨工子
 *Contact：YangGongzi@163.com
 *Website：https://www.yanggongzi.dev
 *所有关于UserService自定义的业务代码应在此处编写
 *由框架生成器生成的部分通用功能在Partial\UserService.cs中
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Mint.Workflow.Entity.Models;
using Mint.Workflow.Repository.DbContexts;
using Mint.Workflow.Repository.IDbContexts;
using Mint.Workflow.Service.IServices;
using Mint.Workflow.Entity.Dtos;
using Mint.Workflow.Entity.Vos;
using Mint.Workflow.Common.Exception;
using JadeFramework.Core.Extensions;

namespace Mint.Workflow.Service.Services;

/// <summary>
///  用户模块Service类
/// </summary>
public partial class UserService : IUserService {

    /// <summary>
    ///  数据库上下文
    /// </summary>
    private IDbContext _dbContext { get; set; }
    
    /// <summary>
    /// DtoToModel映射工具类
    /// </summary>
    /// <param name="entityMapper"></param>
    private IMapper _entityMapper { get; set; }

    /// <summary>
    /// 构造函数
    /// </summary>
    /// <param name="dbContext"></param>
    /// <param name="mapper"></param>
    public UserService(IDbContext dbContext, IMapper entityMapper) {
        _dbContext = dbContext;
        _entityMapper = entityMapper;
    }

    /// <summary>
    /// 用户登录
    /// </summary>
    public async Task<UserLoginVo> LoginAsync(UserLoginDto request){
			
	    // 1 用户名和密码校验
	    if (request.UserName.IsNullOrEmpty() || request.Password.IsNullOrEmpty()) {
		    throw new CommonException("请输入用户名/密码");
	    }

	    // 2 用户名密码判断
	    User user = await _dbContext.UserRepository.FindAsync(m =>
		    m.UserName == request.UserName.TrimBlank() && m.Password == request.Password);
	    if (user == null) {
		    throw new CommonException("用户名/密码错误");
	    }
	    if (user.IsDel) {
		    throw new CommonException("该用户不存在, 请核对改用户是否存在或已注销");
	    }
			
	    // 3 用户信息映射
	    UserLoginVo response = _entityMapper.Map<UserLoginVo>(user);
			
	    return response;
    }
    
}
