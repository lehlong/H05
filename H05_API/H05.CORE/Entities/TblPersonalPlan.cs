using H05.CORE.Common;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace H05.CORE.Entities
{
    [Table("personal_plans")]
    public class TblPersonalPlan : BaseEntity
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        
        [Column("title")]
        public string? Title { get; set; }
        
        [Column("start_date")]
        public DateTime? StartDate { get; set; }
        
        [Column("end_date")]
        public DateTime? EndDate { get; set; }
        
        [Column("sender_id")]
        public int? SenderId { get; set; }
        
        [Column("reviewer_id")]
        public int? ReviewerId { get; set; }
        
        [Column("details")]
        public string? Details { get; set; }
        
        [Column("created_at")]
        public DateTime? CreatedAt { get; set; }
        
        [Column("updated_at")]
        public DateTime? UpdatedAt { get; set; }
        
        [Column("status_approver")]
        public short? StatusApprover { get; set; }
        
        [Column("status_reviewer")]
        public short? StatusReviewer { get; set; }
    }
} 
