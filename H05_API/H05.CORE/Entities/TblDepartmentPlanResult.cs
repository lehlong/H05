using H05.CORE.Common;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace H05.CORE.Entities
{
    [Table("department_plan_results")]
    public class TblDepartmentPlanResult : BaseEntity
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        
        [Column("department_plan_id")]
        public int? DepartmentPlanId { get; set; }
        
        [Column("result_type")]
        public string? ResultType { get; set; }
        
        [Column("category")]
        public string? Category { get; set; }
        
        [Column("content")]
        public string? Content { get; set; }
        
        [Column("progress")]
        public string? Progress { get; set; }
        
        [Column("note")]
        public string? Note { get; set; }
        
        [Column("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }
        
        [Column("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }
    }
} 
