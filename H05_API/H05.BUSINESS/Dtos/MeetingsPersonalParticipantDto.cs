using AutoMapper;
using Common;
using H05.CORE.Entities;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace H05.BUSINESS.Dtos
{
    public class MeetingsPersonalParticipantDto : IMapFrom, IDto
    {
        [Key]
        public int Id { get; set; }
        public int? MeetingId { get; set; }
        public short? ParticipantType { get; set; }
        public int? EmployeeId { get; set; }
        public int? DepartmentId { get; set; }
        public int? RoleId { get; set; }
        public short? RoleType { get; set; }
        public short? ResponseStatus { get; set; }
        public short? AttendanceStatus { get; set; }
        public string? Metadata { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        
        public void Mapping(Profile profile)
        {
            profile.CreateMap<TblMeetingsPersonalParticipant, MeetingsPersonalParticipantDto>().ReverseMap();
        }
    }
} 