using AutoMapper;
using Common;
using H05.CORE.Entities;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace H05.BUSINESS.Dtos
{
    public class MinistryDepartmentDto : IMapFrom, IDto
    {
        [Key]
        public long Id { get; set; }
        public long? WorkRecordId { get; set; }
        public long? DepartmentId { get; set; }
        public short? RoleType { get; set; }
        public string? AssignedTask { get; set; }
        public short? Progress { get; set; }
        public string? EvaluationStatus { get; set; }
        public string? CompletionLevel { get; set; }
        public string? RejectionReason { get; set; }
        public DateTime? EvaluatedAt { get; set; }
        public int? EvaluatedById { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        
        public void Mapping(Profile profile)
        {
            profile.CreateMap<TblMinistryDepartment, MinistryDepartmentDto>().ReverseMap();
        }
    }
} 