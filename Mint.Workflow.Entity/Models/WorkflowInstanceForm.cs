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
/// 流程实例表单数据模块
/// </summary>
[Table("m_workflow_instance_form")]
public class WorkflowInstanceForm { 

    [Key]
    public string InstanceFormId { get; set; }

    public string InstanceId { get; set; }

    public string FormId { get; set; }

    public string FlowContent { get; set; }

    public int FormType { get; set; }

    public string FormUrl { get; set; }

    public string FormData { get; set; }

    public string CreateUserId { get; set; }

    public long CreateTime { get; set; }

	 }
/// <summary>
/// 流程实例表单数据模块表映射
/// </summary>
public sealed class WorkflowInstanceFormMapper : ClassMapper<WorkflowInstanceForm> {
    public WorkflowInstanceFormMapper() {
        // 映射到数据库m_workflow_instance_form表
        Table("m_workflow_instance_form");
        // 字段和属性映射-自动模式
        AutoMap();
    }
}
