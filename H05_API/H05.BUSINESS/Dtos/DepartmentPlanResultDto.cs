using AutoMapper;
using Common;
using H05.CORE.Entities;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace H05.BUSINESS.Dtos
{
    public class DepartmentPlanResultDto : IMapFrom, IDto
    {
        [Key]
        public int Id { get; set; }
        public int? DepartmentPlanId { get; set; }
        public string? ResultType { get; set; }
        public string? Category { get; set; }
        public string? Content { get; set; }
        public string? Progress { get; set; }
        public string? Note { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        
        public void Mapping(Profile profile)
        {
            profile.CreateMap<TblDepartmentPlanResult, DepartmentPlanResultDto>().ReverseMap();
        }
    }
} 