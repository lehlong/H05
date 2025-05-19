using H05.CORE.Common;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace H05.CORE.Entities
{
    [Table("meetings_personal_participants")]
    public class TblMeetingsPersonalParticipant : BaseEntity
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        
        [Column("meeting_id")]
        public int? MeetingId { get; set; }
        
        [Column("participant_type")]
        public short? ParticipantType { get; set; }
        
        [Column("employee_id")]
        public int? EmployeeId { get; set; }
        
        [Column("department_id")]
        public int? DepartmentId { get; set; }
        
        [Column("role_id")]
        public int? RoleId { get; set; }
        
        [Column("role_type")]
        public short? RoleType { get; set; }
        
        [Column("response_status")]
        public short? ResponseStatus { get; set; }
        
        [Column("attendance_status")]
        public short? AttendanceStatus { get; set; }
        
        [Column("metadata")]
        public string? Metadata { get; set; }
        
        [Column("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }
        
        [Column("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }
    }
} 
