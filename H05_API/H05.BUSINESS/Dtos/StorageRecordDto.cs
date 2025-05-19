using AutoMapper;
using Common;
using H05.CORE.Entities;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace H05.BUSINESS.Dtos
{
    public class StorageRecordDto : IMapFrom, IDto
    {
        [Key]
        public long Id { get; set; }
        public long? WorkRecordId { get; set; }
        public long? StorageBoxId { get; set; }
        public short? StorageStatus { get; set; }
        public DateTime? SubmissionDate { get; set; }
        public string? RejectionReason { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public long? CreatedBy { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? MinistrySubmissionDate { get; set; }
        public string? MinistryEvaluationNotes { get; set; }
        
        public void Mapping(Profile profile)
        {
            profile.CreateMap<TblStorageRecord, StorageRecordDto>().ReverseMap();
        }
    }
} 