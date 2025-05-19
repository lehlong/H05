using AutoMapper;
using Common;
using H05.CORE.Entities;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace H05.BUSINESS.Dtos
{
    public class WorkflowStepDto : IMapFrom, IDto
    {
        [Key]
        public int Id { get; set; }
        public int? WorkflowId { get; set; }
        public int? RoleId { get; set; }
        public int? ParentStepId { get; set; }
        public int? DepartmentId { get; set; }
        public int? RequiresOpinionId { get; set; }
        public int? StepOrder { get; set; }
        public bool? IsInternal { get; set; }
        public bool? IsForInformation { get; set; }
        public bool? CanSignReport { get; set; }
        public bool? CanInitialSign { get; set; }
        public bool? CanApproveDraft { get; set; }
        public bool? CanDeleteFile { get; set; }
        public bool? CanReuploadFile { get; set; }
        public DateTimeOffset? CreatedAt { get; set; }
        public DateTimeOffset? UpdatedAt { get; set; }
        public string? RoleDirection { get; set; }
        public string? Consult { get; set; }
        public int? Unit { get; set; }
        public int? SendUnit { get; set; }
        public bool? OfferProcess { get; set; }
        public bool? AllowSendToUnit { get; set; }
        public short? RoleType { get; set; }
        
        public void Mapping(Profile profile)
        {
            profile.CreateMap<TblWorkflowStep, WorkflowStepDto>().ReverseMap();
        }
    }
} 