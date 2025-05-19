using AutoMapper;
using Common;
using H05.CORE.Entities;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace H05.BUSINESS.Dtos
{
    public class BusinessUnitActionDto : IMapFrom, IDto
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int? PermissionId { get; set; }
        public string? Code { get; set; }
        public int? Order { get; set; }
        
        public void Mapping(Profile profile)
        {
            profile.CreateMap<TblBusinessUnitAction, BusinessUnitActionDto>().ReverseMap();
        }
    }
} 