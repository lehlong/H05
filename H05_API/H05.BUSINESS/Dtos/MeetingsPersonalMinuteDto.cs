using AutoMapper;
using Common;
using H05.CORE.Entities;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace H05.BUSINESS.Dtos
{
    public class MeetingsPersonalMinuteDto : IMapFrom, IDto
    {
        [Key]
        public int Id { get; set; }
        public int? MeetingId { get; set; }
        public string? Content { get; set; }
        public int? CreatorId { get; set; }
        public int? Version { get; set; }
        public short? Status { get; set; }
        public string? Attachments { get; set; }
        public string? Metadata { get; set; }
        public DateTimeOffset? CreatedAt { get; set; }
        public DateTimeOffset? UpdatedAt { get; set; }
        
        public void Mapping(Profile profile)
        {
            profile.CreateMap<TblMeetingsPersonalMinute, MeetingsPersonalMinuteDto>().ReverseMap();
        }
    }
} 