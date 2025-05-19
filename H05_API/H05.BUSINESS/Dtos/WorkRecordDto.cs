using AutoMapper;
using Common;
using H05.CORE.Entities;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace H05.BUSINESS.Dtos
{
    public class WorkRecordDto : IMapFrom, IDto
    {
        [Key]
        public long Id { get; set; }
        public string? Name { get; set; }
        public string? RecordCode { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? ConfidentialityLevelId { get; set; }
        public string? ManagementNotes { get; set; }
        public string? WorkContent { get; set; }
        public short? Status { get; set; }
        public short? Progress { get; set; }
        public short? RecordType { get; set; }
        public long? TaskId { get; set; }
        public long? AssignedById { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public int? CreatedBy { get; set; }
        public string? DocumentStatus { get; set; }
        public string? MinistryType { get; set; }
        public int? LeaderId { get; set; }
        public DateTime? DocumentDate { get; set; }
        public int? DocumentTypeId { get; set; }
        public short? Priority { get; set; }
        public short? NoticeExpires { get; set; }
        public int? Organization { get; set; }
        public int? FieldGroup { get; set; }
        public string? RejectedReason { get; set; }
        public int? WorkType { get; set; }
        
        public void Mapping(Profile profile)
        {
            profile.CreateMap<TblWorkRecord, WorkRecordDto>().ReverseMap();
        }
    }
} 