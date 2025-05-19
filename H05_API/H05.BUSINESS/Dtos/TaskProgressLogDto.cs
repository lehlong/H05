using AutoMapper;
using Common;
using H05.CORE.Entities;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace H05.BUSINESS.Dtos
{
    public class TaskProgressLogDto : IMapFrom, IDto
    {
        [Key]
        public int Id { get; set; }
        public int? TaskId { get; set; }
        public int? AssignmentId { get; set; }
        public int? ReporterId { get; set; }
        public short? ProgressPercent { get; set; }
        public short? Status { get; set; }
        public decimal? HoursSpent { get; set; }
        public DateTime? ReportDate { get; set; }
        public string? Description { get; set; }
        public string? Attachments { get; set; }
        public string? Metadata { get; set; }
        public DateTime? CreatedAt { get; set; }
        
        public void Mapping(Profile profile)
        {
            profile.CreateMap<TblTaskProgressLog, TaskProgressLogDto>().ReverseMap();
        }
    }
} 