/*
 *Author：杨工子
 *Contact：YangGongzi@163.com
 *Website：https://www.yanggongzi.dev
 *此文件代码由框架生成器生成,任何更改都可能导致被代码生成器覆盖
*/

using JadeFramework.Core.Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mint.Workflow.Entity.Models;

/// <summary>
/// 资源（菜单）模块
/// </summary>
[Table("m_resource")]
public class Resource { 

    [Key]
    [Identity]
    public long ResourceId { get; set; }

    public long SystemId { get; set; }

    public string ResourceName { get; set; }

    public long ParentId { get; set; }

    public string ResourceUrl { get; set; }

    public int Sort { get; set; }

    public string ButtonClass { get; set; }

    public string Icon { get; set; }

    public bool IsShow { get; set; }

    public long CreateUserId { get; set; }

    public long CreateTime { get; set; }

    public bool IsDel { get; set; }

    public string Memo { get; set; }

    public bool IsButton { get; set; }

    public bool ButtonType { get; set; }

    public string Path { get; set; }

	 }
/// <summary>
/// 资源（菜单）模块表映射
/// </summary>
public sealed class ResourceMapper : ClassMapper<Resource> {
    public ResourceMapper() {
        // 映射到数据库m_resource表
        Table("m_resource");
        // 字段和属性映射-自动模式
        AutoMap();
    }
}
