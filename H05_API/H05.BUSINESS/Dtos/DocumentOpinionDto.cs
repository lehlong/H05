using AutoMapper;
using Common;
using H05.CORE.Entities;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace H05.BUSINESS.Dtos
{
    public class DocumentOpinionDto : IMapFrom, IDto
    {
        [Key]
        public long Id { get; set; }
        public string? DocumentType { get; set; }
        public long? IncomingDocumentId { get; set; }
        public long? OutgoingDocumentId { get; set; }
        public int? UserId { get; set; }
        public string? Content { get; set; }
        public long? ParentId { get; set; }
        public DateTimeOffset? CreatedAt { get; set; }
        public DateTimeOffset? UpdatedAt { get; set; }
        public string? Attachments { get; set; }
        public string? OutGoingDocumentAction { get; set; }
        public int? RecipientId { get; set; }
        public string? ForwardRequestOpinion { get; set; }
        public int? PrivateId { get; set; }
        public string? PrivateType { get; set; }
        
        public void Mapping(Profile profile)
        {
            profile.CreateMap<TblDocumentOpinion, DocumentOpinionDto>().ReverseMap();
        }
    }
} 