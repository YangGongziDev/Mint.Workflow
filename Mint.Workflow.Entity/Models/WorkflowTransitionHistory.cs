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
/// 流程转交历史模块
/// </summary>
[Table("m_workflow_transition_history")]
public class WorkflowTransitionHistory { 

    [Key]
    public string TransitionId { get; set; }

    public string InstanceId { get; set; }

    public string FromNodeId { get; set; }

    public int FromNodeType { get; set; }

    public string FromNodName { get; set; }

    public string ToNodeId { get; set; }

    public int ToNodeType { get; set; }

    public string ToNodeName { get; set; }

    public int TransitionState { get; set; }

    public int IsFinish { get; set; }

    public string CreateUserName { get; set; }

    public string CreateUserId { get; set; }

    public long CreateTime { get; set; }

	 }
/// <summary>
/// 流程转交历史模块表映射
/// </summary>
public sealed class WorkflowTransitionHistoryMapper : ClassMapper<WorkflowTransitionHistory> {
    public WorkflowTransitionHistoryMapper() {
        // 映射到数据库m_workflow_transition_history表
        Table("m_workflow_transition_history");
        // 字段和属性映射-自动模式
        AutoMap();
    }
}
