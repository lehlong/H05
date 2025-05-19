using H05.CORE.Common;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace H05.CORE.Entities
{
    [Table("meetings_department_resource_bookings")]
    public class TblMeetingsDepartmentResourceBooking : BaseEntity
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        
        [Column("meeting_id")]
        public int? MeetingId { get; set; }
        
        [Column("resource_id")]
        public int? ResourceId { get; set; }
        
        [Column("start_time")]
        public DateTime? StartTime { get; set; }
        
        [Column("end_time")]
        public DateTime? EndTime { get; set; }
        
        [Column("status")]
        public short? Status { get; set; }
        
        [Column("notes")]
        public string? Notes { get; set; }
        
        [Column("metadata")]
        public string? Metadata { get; set; }
        
        [Column("created_at")]
        public DateTime? CreatedAt { get; set; }
        
        [Column("updated_at")]
        public DateTime? UpdatedAt { get; set; }
        
        [Column("meeting_type_id")]
        public int? MeetingTypeId { get; set; }
        
        [Column("contents")]
        public string? Contents { get; set; }
        
        [Column("attendee_information")]
        public string? AttendeeInformation { get; set; }
        
        [Column("group_order")]
        public int? GroupOrder { get; set; }
    }
} 
