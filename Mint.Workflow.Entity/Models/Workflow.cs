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
/// 流程定义模块
/// </summary>
[Table("m_workflow")]
public class Workflow { 

    [Key]
    public string FlowId { get; set; }

    public string FlowCode { get; set; }

    public string CategoryId { get; set; }

    public string FormId { get; set; }

    public string FlowName { get; set; }

    public string FlowContent { get; set; }

    public int FlowVersion { get; set; }

    public string Memo { get; set; }

    public int Enable { get; set; }

    public int IsOld { get; set; }

    public string CreateUserId { get; set; }

    public long CreateTime { get; set; }

	 }
/// <summary>
/// 流程定义模块表映射
/// </summary>
public sealed class WorkflowMapper : ClassMapper<Entity.Models.Workflow> {
    public WorkflowMapper() {
        // 映射到数据库m_workflow表
        Table("m_workflow");
        // 字段和属性映射-自动模式
        AutoMap();
    }
}
