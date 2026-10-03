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
/// 流程分类模块
/// </summary>
[Table("m_workflow_category")]
public class WorkflowCategory { 

    [Key]
    public string CategoryId { get; set; }

    public string Name { get; set; }

    public string ParentId { get; set; }

    public string Memo { get; set; }

    public int Status { get; set; }

    public string CreateUserId { get; set; }

    public long CreateTime { get; set; }

	 }
/// <summary>
/// 流程分类模块表映射
/// </summary>
public sealed class WorkflowCategoryMapper : ClassMapper<WorkflowCategory> {
    public WorkflowCategoryMapper() {
        // 映射到数据库m_workflow_category表
        Table("m_workflow_category");
        // 字段和属性映射-自动模式
        AutoMap();
    }
}
