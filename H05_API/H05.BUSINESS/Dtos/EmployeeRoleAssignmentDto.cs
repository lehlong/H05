using AutoMapper;
using Common;
using H05.CORE.Entities;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace H05.BUSINESS.Dtos
{
    public class EmployeeRoleAssignmentDto : IMapFrom, IDto
    {
        [Key]
        public int Id { get; set; }
        public int? EmployeeId { get; set; }
        public int? RoleId { get; set; }
        public int? DepartmentId { get; set; }
        public bool? IsActive { get; set; }
        public string? Settings { get; set; }
        public DateTimeOffset? CreatedAt { get; set; }
        public DateTimeOffset? UpdatedAt { get; set; }
        
        public void Mapping(Profile profile)
        {
            profile.CreateMap<TblEmployeeRoleAssignment, EmployeeRoleAssignmentDto>().ReverseMap();
        }
    }
} 