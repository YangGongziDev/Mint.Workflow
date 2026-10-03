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
/// 流程操作历史模块
/// </summary>
[Table("m_workflow_operation_history")]
public class WorkflowOperationHistory { 

    [Key]
    public string OperationId { get; set; }

    public string InstanceId { get; set; }

    public string NodeId { get; set; }

    public string NodeName { get; set; }

    public int TransitionType { get; set; }

    public string Content { get; set; }

    public string CreateUserName { get; set; }

    public string CreateUserId { get; set; }

    public long CreateTime { get; set; }

	 }
/// <summary>
/// 流程操作历史模块表映射
/// </summary>
public sealed class WorkflowOperationHistoryMapper : ClassMapper<WorkflowOperationHistory> {
    public WorkflowOperationHistoryMapper() {
        // 映射到数据库m_workflow_operation_history表
        Table("m_workflow_operation_history");
        // 字段和属性映射-自动模式
        AutoMap();
    }
}
