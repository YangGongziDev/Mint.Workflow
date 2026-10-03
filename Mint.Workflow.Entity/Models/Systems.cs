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
/// 系统模块
/// </summary>
[Table("m_systems")]
public class Systems { 

    [Key]
    [Identity]
    public long SystemId { get; set; }

    public string SystemName { get; set; }

    public string SystemCode { get; set; }

    public bool IsDel { get; set; }

    public string Memo { get; set; }

    public int Sort { get; set; }

    public long CreateTime { get; set; }

    public long CreateUserId { get; set; }

    public long UpdateTime { get; set; }

	 }
/// <summary>
/// 系统模块表映射
/// </summary>
public sealed class SystemsMapper : ClassMapper<Systems> {
    public SystemsMapper() {
        // 映射到数据库m_systems表
        Table("m_systems");
        // 字段和属性映射-自动模式
        AutoMap();
    }
}
