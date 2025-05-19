using AutoMapper;
using Common;
using H05.CORE.Entities;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace H05.BUSINESS.Dtos
{
    public class TaskAssignmentDto : IMapFrom, IDto
    {
        [Key]
        public int Id { get; set; }
        public int? TaskId { get; set; }
        public short? AssigneeType { get; set; }
        public int? EmployeeId { get; set; }
        public int? DepartmentId { get; set; }
        public int? RoleId { get; set; }
        public short? AssignmentType { get; set; }
        public short? Status { get; set; }
        public short? ProgressPercent { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? CompletedDate { get; set; }
        public int? EstimatedHours { get; set; }
        public int? ActualHours { get; set; }
        public string? Settings { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        
        public void Mapping(Profile profile)
        {
            profile.CreateMap<TblTaskAssignment, TaskAssignmentDto>().ReverseMap();
        }
    }
} 