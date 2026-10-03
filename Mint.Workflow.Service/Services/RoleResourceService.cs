/*
 *Author：杨工子
 *Contact：YangGongzi@163.com
 *Website：https://www.yanggongzi.dev
 *所有关于RoleResourceService自定义的业务代码应在此处编写
 *由框架生成器生成的部分通用功能在Partial\RoleResourceService.cs中
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
///  角色资源关联模块Service类
/// </summary>
public partial class RoleResourceService : IRoleResourceService {

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
    public RoleResourceService(IDbContext dbContext, IMapper entityMapper) {
        _dbContext = dbContext;
        _entityMapper = entityMapper;
    }

    /// <summary>
    /// 
    /// </summary>
    
}
