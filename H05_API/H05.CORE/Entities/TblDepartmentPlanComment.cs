using H05.CORE.Common;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace H05.CORE.Entities
{
    [Table("department_plan_comments")]
    public class TblDepartmentPlanComment : BaseEntity
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        
        [Column("department_plan_id")]
        public int? DepartmentPlanId { get; set; }
        
        [Column("user_id")]
        public int? UserId { get; set; }
        
        [Column("content")]
        public string? Content { get; set; }
        
        [Column("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }
        
        [Column("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }
        
        [Column("parent_id")]
        public int? ParentId { get; set; }
        
        [Column("is_transfer")]
        public bool? IsTransfer { get; set; }
        
        [Column("is_done")]
        public bool? IsDone { get; set; }
    }
} 
