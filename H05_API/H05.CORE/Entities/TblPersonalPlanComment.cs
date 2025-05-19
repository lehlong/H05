using H05.CORE.Common;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace H05.CORE.Entities
{
    [Table("personal_plan_comments")]
    public class TblPersonalPlanComment : BaseEntity
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        
        [Column("personal_plan_id")]
        public int? PersonalPlanId { get; set; }
        
        [Column("user_id")]
        public int? UserId { get; set; }
        
        [Column("content")]
        public string? Content { get; set; }
        
        [Column("created_at")]
        public DateTime? CreatedAt { get; set; }
        
        [Column("parent_id")]
        public int? ParentId { get; set; }
        
        [Column("is_transfer")]
        public bool? IsTransfer { get; set; }
        
        [Column("is_done")]
        public bool? IsDone { get; set; }
        
        [Column("updated_at")]
        public DateTime? UpdatedAt { get; set; }
    }
} 
