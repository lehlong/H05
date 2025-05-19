using AutoMapper;
using Common;
using H05.CORE.Entities;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace H05.BUSINESS.Dtos
{
    public class WorkRecordTaskDto : IMapFrom, IDto
    {
        [Key]
        public long Id { get; set; }
        public string? TaskContent { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? WorkRecordId { get; set; }
        public string? RecordCode { get; set; }
        public DateTime? DocumentDate { get; set; }
        public int? LeaderId { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? FieldGroup { get; set; }
        public int? Priority { get; set; }
        public int? TaskGroupId { get; set; }
        public int? DepartmentId { get; set; }
        public int? TaskType { get; set; }
        public short? ReportFrequency { get; set; }
        public string? RequestContent { get; set; }
        public bool? IsTaskGroup { get; set; }
        public string? Organizations { get; set; }
        
        public void Mapping(Profile profile)
        {
            profile.CreateMap<TblWorkRecordTask, WorkRecordTaskDto>().ReverseMap();
        }
    }
} 