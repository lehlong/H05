using AutoMapper;
using Common;
using H05.CORE.Entities;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace H05.BUSINESS.Dtos
{
    public class WorkflowDto : IMapFrom, IDto
    {
        [Key]
        public int Id { get; set; }
        public string? WorkflowCode { get; set; }
        public string? WorkflowName { get; set; }
        public int? ResourceTypeId { get; set; }
        public string? DepartmentScope { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public bool? IsActive { get; set; }
        public string? ApplyScope { get; set; }
        
        public void Mapping(Profile profile)
        {
            profile.CreateMap<TblWorkflow, WorkflowDto>().ReverseMap();
        }
    }
} 