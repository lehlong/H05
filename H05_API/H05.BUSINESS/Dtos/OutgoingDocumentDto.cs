using AutoMapper;
using Common;
using H05.CORE.Entities;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace H05.BUSINESS.Dtos
{
    public class OutgoingDocumentDto : IMapFrom, IDto
    {
        [Key]
        public int Id { get; set; }
        public string? DocumentNumber { get; set; }
        public string? DraftReferenceNumber { get; set; }
        public string? ReportReferenceNumber { get; set; }
        public string? Summary { get; set; }
        public int? DraftingDepartmentId { get; set; }
        public int? PublishingDepartmentId { get; set; }
        public int? DrafterId { get; set; }
        public int? DocumentTypeId { get; set; }
        public int? UrgencyLevelId { get; set; }
        public int? SecurityLevelId { get; set; }
        public int? FieldId { get; set; }
        public int? ReportSignerId { get; set; }
        public int? DraftSignerId { get; set; }
        public DateTime? ResponseDeadline { get; set; }
        public string? Status { get; set; }
        public int? StatusId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTimeOffset? CreatedAt { get; set; }
        public DateTimeOffset? UpdatedAt { get; set; }
        public DateTime? PublishedDate { get; set; }
        public bool? AutoPublish { get; set; }
        public bool? DigitalSignature { get; set; }
        public string? ProcessingStatus { get; set; }
        public DateTimeOffset? DeletedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public int? DeletedBy { get; set; }
        public bool? IsSignDraft { get; set; }
        public bool? IsSignReport { get; set; }
        public long? ViewerId { get; set; }
        public int? PublisherId { get; set; }
        
        public void Mapping(Profile profile)
        {
            profile.CreateMap<TblOutgoingDocument, OutgoingDocumentDto>().ReverseMap();
        }
    }
} 