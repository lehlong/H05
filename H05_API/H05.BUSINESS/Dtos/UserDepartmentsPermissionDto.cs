using AutoMapper;
using Common;
using H05.CORE.Entities;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace H05.BUSINESS.Dtos
{
    public class UserDepartmentsPermissionDto : IMapFrom, IDto
    {
        [Key]
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int? DepartmentId { get; set; }
        public bool? IsCan { get; set; }
        public string? Action { get; set; }
        public bool? IsActive { get; set; }
        public DateTimeOffset? CreatedAt { get; set; }
        public int? RoleId { get; set; }
        public int? PermissionId { get; set; }
        public int? DepartmentTypeId { get; set; }
        
        public void Mapping(Profile profile)
        {
            profile.CreateMap<TblUserDepartmentsPermission, UserDepartmentsPermissionDto>().ReverseMap();
        }
    }
} 