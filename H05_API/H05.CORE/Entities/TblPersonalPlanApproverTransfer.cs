using H05.CORE.Common;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace H05.CORE.Entities
{
    [Table("personal_plan_approver_transfers")]
    public class TblPersonalPlanApproverTransfer 
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        
        [Column("personal_plan_id")]
        public int? PersonalPlanId { get; set; }
        
        [Column("from_user_id")]
        public int? FromUserId { get; set; }
        
        [Column("to_user_id")]
        public int? ToUserId { get; set; }
        
        [Column("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }
        
        [Column("is_approved")]
        public bool? IsApproved { get; set; }
        
        [Column("personal_plan_comment_id")]
        public int? PersonalPlanCommentId { get; set; }
        
        [Column("status_approver")]
        public short? StatusApprover { get; set; }
    }
} 
