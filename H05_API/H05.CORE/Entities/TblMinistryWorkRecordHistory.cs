using H05.CORE.Common;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace H05.CORE.Entities
{
    [Table("ministry_work_record_history")]
    public class TblMinistryWorkRecordHistory : BaseEntity
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }
        
        [Column("work_record_id")]
        public long? WorkRecordId { get; set; }
        
        [Column("action_type")]
        public string? ActionType { get; set; }
        
        [Column("action_date")]
        public DateTimeOffset? ActionDate { get; set; }
        
        [Column("user_id")]
        public int? UserId { get; set; }
        
        [Column("description")]
        public string? Description { get; set; }
        
        [Column("old_values")]
        public string? OldValues { get; set; }
        
        [Column("new_values")]
        public string? NewValues { get; set; }
    }
}
