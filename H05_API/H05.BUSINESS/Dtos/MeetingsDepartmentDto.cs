using AutoMapper;
using Common;
using H05.CORE.Entities;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace H05.BUSINESS.Dtos
{
    public class MeetingsDepartmentDto : IMapFrom, IDto
    {
        [Key]
        public int Id { get; set; }
        public string? Title { get; set; }
        public DateTimeOffset? StartTime { get; set; }
        public DateTimeOffset? EndTime { get; set; }
        public short? Status { get; set; }
        public int? AuthorId { get; set; }
        public int? DepartmentId { get; set; }
        public string? PreparationInfo { get; set; }
        public string? ReminderSettings { get; set; }
        public string? Metadata { get; set; }
        public DateTimeOffset? CreatedAt { get; set; }
        public DateTimeOffset? UpdatedAt { get; set; }
        public int? PublisherId { get; set; }
        public bool? IsPublish { get; set; }
        
        public void Mapping(Profile profile)
        {
            profile.CreateMap<TblMeetingsDepartment, MeetingsDepartmentDto>().ReverseMap();
        }
    }
} 