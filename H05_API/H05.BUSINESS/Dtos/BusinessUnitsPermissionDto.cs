using AutoMapper;
using Common;
using H05.CORE.Entities;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace H05.BUSINESS.Dtos
{
    public class BusinessUnitsPermissionDto : IMapFrom, IDto
    {
        [Key]
        public int Id { get; set; }
        public int? BusinessUnitId { get; set; }
        public bool? IsCan { get; set; }
        public bool? IsActive { get; set; }
        public DateTimeOffset? CreatedAt { get; set; }
        public int? RoleId { get; set; }
        public int? BusinessUnitTypeId { get; set; }
        public int? PermissionId { get; set; }
        
        public void Mapping(Profile profile)
        {
            profile.CreateMap<TblBusinessUnitsPermission, BusinessUnitsPermissionDto>().ReverseMap();
        }
    }
} 