using H05.CORE.Common;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace H05.CORE.Entities
{
    [Table("outgoing_document_processing_history")]
    public class TblOutgoingDocumentProcessingHistory : BaseEntity
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        
        [Column("document_id")]
        public int? DocumentId { get; set; }
        
        [Column("action_type")]
        public string? ActionType { get; set; }
        
        [Column("action_date")]
        public DateTimeOffset? ActionDate { get; set; }
        
        [Column("actor_id")]
        public int? ActorId { get; set; }
        
        [Column("previous_status")]
        public string? PreviousStatus { get; set; }
        
        [Column("new_status")]
        public string? NewStatus { get; set; }
        
        [Column("comments")]
        public string? Comments { get; set; }
        
        [Column("department_id")]
        public int? DepartmentId { get; set; }
        
        [Column("created_by")]
        public int? CreatedBy { get; set; }
        
        [Column("status")]
        public string? Status { get; set; }
        
        [Column("type")]
        public string? Type { get; set; }
        
        [Column("task_type")]
        public string? TaskType { get; set; }
    }
} 
