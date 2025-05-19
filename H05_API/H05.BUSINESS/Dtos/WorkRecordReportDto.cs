using AutoMapper;
using Common;
using H05.CORE.Entities;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace H05.BUSINESS.Dtos
{
    public class WorkRecordReportDto : IMapFrom, IDto
    {
        [Key]
        public int Id { get; set; }
        public DateTime? Date { get; set; }
        public string? Content { get; set; }
        public string? EmpIds { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public int? CreatedBy { get; set; }
        public bool? IsRequest { get; set; }
        public int? RequestId { get; set; }
        public int? WorkRecordId { get; set; }
        
        public void Mapping(Profile profile)
        {
            profile.CreateMap<TblWorkRecordReport, WorkRecordReportDto>().ReverseMap();
        }
    }
} 