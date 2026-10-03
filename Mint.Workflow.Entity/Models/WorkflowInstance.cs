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
/// 流程实例模块（运行中的流程）
/// </summary>
[Table("m_workflow_instance")]
public class WorkflowInstance { 

    [Key]
    public string InstanceId { get; set; }

    public string FlowId { get; set; }

    public string Code { get; set; }

    public string ActivityId { get; set; }

    public int ActivityType { get; set; }

    public string ActivityName { get; set; }

    public string PreviousId { get; set; }

    public string MakerList { get; set; }

    public string FlowContent { get; set; }

    public int FlowVersion { get; set; }

    public string CreateUserName { get; set; }

    public long UpdateTime { get; set; }

    public string CreateUserId { get; set; }

    public long CreateTime { get; set; }

	 }
/// <summary>
/// 流程实例模块（运行中的流程）表映射
/// </summary>
public sealed class WorkflowInstanceMapper : ClassMapper<WorkflowInstance> {
    public WorkflowInstanceMapper() {
        // 映射到数据库m_workflow_instance表
        Table("m_workflow_instance");
        // 字段和属性映射-自动模式
        AutoMap();
    }
}
