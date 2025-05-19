using AutoMapper;
using Common;
using H05.CORE.Entities;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace H05.BUSINESS.Dtos
{
    public class WorkRecordReportStatusDto : IMapFrom, IDto
    {
        [Key]
        public long Id { get; set; }
        public int? ReportId { get; set; }
        public int? EmpId { get; set; }
        public bool? IsSeen { get; set; }
        
        public void Mapping(Profile profile)
        {
            profile.CreateMap<TblWorkRecordReportStatus, WorkRecordReportStatusDto>().ReverseMap();
        }
    }
} 