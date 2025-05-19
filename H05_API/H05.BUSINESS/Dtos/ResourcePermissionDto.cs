using AutoMapper;
using Common;
using H05.CORE.Entities;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace H05.BUSINESS.Dtos
{
    public class ResourcePermissionDto : IMapFrom, IDto
    {
        [Key]
        public int Id { get; set; }
        public string? ResourceType { get; set; }
        public int? ResourceId { get; set; }
        public short? GranteeType { get; set; }
        public int? UserId { get; set; }
        public int? RoleId { get; set; }
        public int? DepartmentId { get; set; }
        public short? PermissionLevel { get; set; }
        public bool? IsInherited { get; set; }
        public int? GrantedBy { get; set; }
        public DateTime? ValidFrom { get; set; }
        public DateTime? ValidUntil { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        
        public void Mapping(Profile profile)
        {
            profile.CreateMap<TblResourcePermission, ResourcePermissionDto>().ReverseMap();
        }
    }
} 