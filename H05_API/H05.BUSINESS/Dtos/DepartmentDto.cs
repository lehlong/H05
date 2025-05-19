using AutoMapper;
using Common;
using H05.CORE.Entities;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace H05.BUSINESS.Dtos
{
    public class DepartmentDto : IMapFrom, IDto
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Code { get; set; }
        public int? ParentId { get; set; }
        public short? TypeId { get; set; }
        public string? ContactInfo { get; set; }
        public string? Description { get; set; }
        public short? DisplayOrder { get; set; }
        public bool? IsActive { get; set; }
        public string? ObjectId { get; set; }
        public string? Type { get; set; }
        public int? Status { get; set; }
        
        public void Mapping(Profile profile)
        {
            profile.CreateMap<TblDepartment, DepartmentDto>().ReverseMap();
        }
    }
} 