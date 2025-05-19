using AutoMapper;
using Common;
using H05.CORE.Entities;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace H05.BUSINESS.Dtos
{
    public class MeetingsDepartmentResourceBookingDto : IMapFrom, IDto
    {
        [Key]
        public int Id { get; set; }
        public int? MeetingId { get; set; }
        public int? ResourceId { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public short? Status { get; set; }
        public string? Notes { get; set; }
        public string? Metadata { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? MeetingTypeId { get; set; }
        public string? Contents { get; set; }
        public string? AttendeeInformation { get; set; }
        public int? GroupOrder { get; set; }
        
        public void Mapping(Profile profile)
        {
            profile.CreateMap<TblMeetingsDepartmentResourceBooking, MeetingsDepartmentResourceBookingDto>().ReverseMap();
        }
    }
} 