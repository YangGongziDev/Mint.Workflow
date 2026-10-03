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
/// 用户部门关联模块
/// </summary>
[Table("m_user_dept")]
public class UserDept { 

    [Key]
    [Identity]
    public long Id { get; set; }

    public long UserId { get; set; }

    public long DeptId { get; set; }

    public long CreateTime { get; set; }

	 }
/// <summary>
/// 用户部门关联模块表映射
/// </summary>
public sealed class UserDeptMapper : ClassMapper<UserDept> {
    public UserDeptMapper() {
        // 映射到数据库m_user_dept表
        Table("m_user_dept");
        // 字段和属性映射-自动模式
        AutoMap();
    }
}
