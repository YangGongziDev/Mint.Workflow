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
/// 部门模块
/// </summary>
[Table("m_dept")]
public class Dept { 

    [Key]
    [Identity]
    public long DeptId { get; set; }

    public long SystemId { get; set; }

    public string DeptName { get; set; }

    public string DeptCode { get; set; }

    public long ParentId { get; set; }

    public string Path { get; set; }

    public bool IsDel { get; set; }

    public string Memo { get; set; }

    public long CreateUserId { get; set; }

    public long CreateTime { get; set; }

	 }
/// <summary>
/// 部门模块表映射
/// </summary>
public sealed class DeptMapper : ClassMapper<Dept> {
    public DeptMapper() {
        // 映射到数据库m_dept表
        Table("m_dept");
        // 字段和属性映射-自动模式
        AutoMap();
    }
}
