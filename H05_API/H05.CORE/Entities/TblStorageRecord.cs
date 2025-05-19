using H05.CORE.Common;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace H05.CORE.Entities
{
    [Table("storage_records")]
    public class TblStorageRecord 
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }
        
        [Column("work_record_id")]
        public long? WorkRecordId { get; set; }
        
        [Column("storage_box_id")]
        public long? StorageBoxId { get; set; }
        
        [Column("storage_status")]
        public short? StorageStatus { get; set; }
        
        [Column("submission_date")]
        public DateTimeOffset? SubmissionDate { get; set; }
        
        [Column("rejection_reason")]
        public string? RejectionReason { get; set; }
        
        [Column("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }
        
        [Column("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }
        
        [Column("created_by")]
        public long? CreatedBy { get; set; }
        
        [Column("updated_by")]
        public long? UpdatedBy { get; set; }
        
        [Column("ministry_submission_date")]
        public DateTimeOffset? MinistrySubmissionDate { get; set; }
        
        [Column("ministry_evaluation_notes")]
        public string? MinistryEvaluationNotes { get; set; }
    }
} 
