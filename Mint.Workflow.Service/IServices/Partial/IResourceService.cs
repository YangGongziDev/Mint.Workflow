/*
 *Author：杨工子
 *Contact：YangGongzi@163.com
 *Website：https://www.yanggongzi.dev
 *此文件代码由框架生成器生成,任何更改都可能导致被代码生成器覆盖
 *所有自定义业务代码都应在 非Partial 文件夹下的IResourceService.cs中编写
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
/// 资源（菜单）模块IService接口
/// </summary>
public partial interface IResourceService {

    /// <summary>
    /// 添加资源（菜单）模块
    /// </summary>
    /// <param name="Resource"></param>
    /// <returns></returns>
    Task<bool> AddResourceAsync(Resource resource);

    /// <summary>
    /// 删除资源（菜单）模块
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    Task<bool> DeleteResourceAsync(long id);

    /// <summary>
    ///  修改资源（菜单）模块
    /// </summary>
    /// <param name="Resource"></param>
    /// <returns></returns>
    Task<bool> UpdateResourceAsync(Resource resource);

    /// <summary>
    /// 根据Id获取资源（菜单）模块信息详情
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    Task<Resource> GetResourceByIdAsync(long id);
    
}
