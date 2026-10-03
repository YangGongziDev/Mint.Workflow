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
/// 角色模块
/// </summary>
[Table("m_role")]
public class Role { 

    [Key]
    [Identity]
    public long RoleId { get; set; }

    public long SystemId { get; set; }

    public string RoleName { get; set; }

    public string Memo { get; set; }

    public bool IsDel { get; set; }

    public long CreateUserId { get; set; }

    public long CreateTime { get; set; }

    public long UpdateUserId { get; set; }

    public long UpdateTime { get; set; }

	 }
/// <summary>
/// 角色模块表映射
/// </summary>
public sealed class RoleMapper : ClassMapper<Role> {
    public RoleMapper() {
        // 映射到数据库m_role表
        Table("m_role");
        // 字段和属性映射-自动模式
        AutoMap();
    }
}
