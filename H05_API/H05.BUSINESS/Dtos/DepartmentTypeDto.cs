using AutoMapper;
using Common;
using H05.CORE.Entities;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace H05.BUSINESS.Dtos
{
    public class DepartmentTypeDto : IMapFrom, IDto
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        
        public void Mapping(Profile profile)
        {
            profile.CreateMap<TblDepartmentType, DepartmentTypeDto>().ReverseMap();
        }
    }
} 