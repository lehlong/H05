using H05.CORE.Common;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace H05.CORE.Entities
{
    [Table("meetings_personal")]
    public class TblMeetingsPersonal : BaseEntity
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        
        [Column("title")]
        public string? Title { get; set; }
        
        [Column("content")]
        public string? Content { get; set; }
        
        [Column("location_id")]
        public int? LocationId { get; set; }
        
        [Column("start_time")]
        public DateTime? StartTime { get; set; }
        
        [Column("end_time")]
        public DateTime? EndTime { get; set; }
        
        [Column("status")]
        public short? Status { get; set; }
        
        [Column("organizer_id")]
        public int? OrganizerId { get; set; }
        
        [Column("preparation_info")]
        public string? PreparationInfo { get; set; }
        
        [Column("reminder_settings")]
        public string? ReminderSettings { get; set; }
        
        [Column("metadata")]
        public string? Metadata { get; set; }
        
        [Column("created_at")]
        public DateTime? CreatedAt { get; set; }
        
        [Column("updated_at")]
        public DateTime? UpdatedAt { get; set; }
        
        [Column("created_by")]
        public int? CreatedBy { get; set; }
    }
} 
