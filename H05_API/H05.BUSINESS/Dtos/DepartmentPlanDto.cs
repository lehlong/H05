using AutoMapper;
using Common;
using H05.CORE.Entities;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace H05.BUSINESS.Dtos
{
    public class DepartmentPlanDto : IMapFrom, IDto
    {
        [Key]
        public int Id { get; set; }
        public string? Title { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? DepartmentId { get; set; }
        public short? Status { get; set; }
        public int? SenderId { get; set; }
        
        public void Mapping(Profile profile)
        {
            profile.CreateMap<TblDepartmentPlan, DepartmentPlanDto>().ReverseMap();
        }
    }
} 