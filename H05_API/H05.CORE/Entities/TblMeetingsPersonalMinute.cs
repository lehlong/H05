using H05.CORE.Common;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace H05.CORE.Entities
{
    [Table("meetings_personal_minutes")]
    public class TblMeetingsPersonalMinute 
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        
        [Column("meeting_id")]
        public int? MeetingId { get; set; }
        
        [Column("content")]
        public string? Content { get; set; }
        
        [Column("creator_id")]
        public int? CreatorId { get; set; }
        
        [Column("version")]
        public int? Version { get; set; }
        
        [Column("status")]
        public short? Status { get; set; }
        
        [Column("attachments")]
        public string? Attachments { get; set; }
        
        [Column("metadata")]
        public string? Metadata { get; set; }
        
        [Column("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }
        
        [Column("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }
    }
} 
