using AutoMapper;
using Common;
using H05.CORE.Entities;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace H05.BUSINESS.Dtos
{
    public class DepartmentPlansEmployeeDto : IMapFrom, IDto
    {
        [Key]
        public int Id { get; set; }
        public int? DepartmentPlanId { get; set; }
        public int? EmployeeId { get; set; }
        public bool? IsViewed { get; set; }
        public DateTimeOffset? CreatedAt { get; set; }
        public DateTimeOffset? UpdatedAt { get; set; }
        
        public void Mapping(Profile profile)
        {
            profile.CreateMap<TblDepartmentPlansEmployee, DepartmentPlansEmployeeDto>().ReverseMap();
        }
    }
} 