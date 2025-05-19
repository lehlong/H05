using AutoMapper;
using Common;
using H05.CORE.Entities;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace H05.BUSINESS.Dtos
{
    public class MeetingResourceDto : IMapFrom, IDto
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Code { get; set; }
        public short? TypeId { get; set; }
        public int? DepartmentId { get; set; }
        public string? Description { get; set; }
        public int? Capacity { get; set; }
        public string? Location { get; set; }
        public short? Status { get; set; }
        public string? Settings { get; set; }
        public bool? IsActive { get; set; }
        public string? Metadata { get; set; }
        public DateTimeOffset? CreatedAt { get; set; }
        public DateTimeOffset? UpdatedAt { get; set; }
        public short? Area { get; set; }
        public string? Utilities { get; set; }
        
        public void Mapping(Profile profile)
        {
            profile.CreateMap<TblMeetingResource, MeetingResourceDto>().ReverseMap();
        }
    }
} 