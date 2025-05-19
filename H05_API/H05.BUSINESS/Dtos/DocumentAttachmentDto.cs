using AutoMapper;
using Common;
using H05.CORE.Entities;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace H05.BUSINESS.Dtos
{
    public class DocumentAttachmentDto : IMapFrom, IDto
    {
        [Key]
        public long Id { get; set; }
        public string? DocumentType { get; set; }
        public long? IncomingDocumentId { get; set; }
        public long? OutgoingDocumentId { get; set; }
        public long? FileId { get; set; }
        public string? AttachmentType { get; set; }
        public DateTimeOffset? CreatedAt { get; set; }
        public bool? IsSigned { get; set; }
        public long? DocumentBookId { get; set; }
        public string? DocumentNumber { get; set; }
        public string? Symbol { get; set; }
        public DateTime? IssueDate { get; set; }
        public long? ParentAttachmentId { get; set; }
        public string? VersionType { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsInitialSigned { get; set; }
        
        public void Mapping(Profile profile)
        {
            profile.CreateMap<TblDocumentAttachment, DocumentAttachmentDto>().ReverseMap();
        }
    }
} 