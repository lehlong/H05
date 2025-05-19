using AutoMapper;
using Common;
using H05.CORE.Entities;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace H05.BUSINESS.Dtos
{
    public class RolePermissionDto : IMapFrom, IDto
    {
        [Key]
        public int Id { get; set; }
        public int? RoleId { get; set; }
        public int? PermissionTypeId { get; set; }
        public string? AdditionalRights { get; set; }
        public string? Conditions { get; set; }
        public DateTimeOffset? CreatedAt { get; set; }
        public DateTimeOffset? UpdatedAt { get; set; }
        public int? PermissionId { get; set; }
        public bool? IsCan { get; set; }
        
        public void Mapping(Profile profile)
        {
            profile.CreateMap<TblRolePermission, RolePermissionDto>().ReverseMap();
        }
    }
} 