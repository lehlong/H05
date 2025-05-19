using H05.CORE.Common;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace H05.CORE.Entities
{
    [Table("department_plan_transfers")]
    public class TblDepartmentPlanTransfer : BaseEntity
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        
        [Column("department_plan_id")]
        public int? DepartmentPlanId { get; set; }
        
        [Column("from_user_id")]
        public int? FromUserId { get; set; }
        
        [Column("to_user_id")]
        public int? ToUserId { get; set; }
        
        [Column("created_at")]
        public DateTime? CreatedAt { get; set; }
        
        [Column("is_approved")]
        public bool? IsApproved { get; set; }
        
        [Column("department_plan_comment_id")]
        public int? DepartmentPlanCommentId { get; set; }
        
        [Column("status")]
        public short? Status { get; set; }
    }
} 
