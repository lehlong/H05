using AutoMapper;
using Common;
using H05.CORE.Entities;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace H05.BUSINESS.Dtos
{
    public class DocumentHistoryDto : IMapFrom, IDto
    {
        [Key]
        public long Id { get; set; }
        public string? DocumentType { get; set; }
        public long? IncomingDocumentId { get; set; }
        public long? OutgoingDocumentId { get; set; }
        public string? Action { get; set; }
        public string? OldValue { get; set; }
        public string? NewValue { get; set; }
        public int? ChangedById { get; set; }
        public DateTime? CreatedAt { get; set; }
        
        public void Mapping(Profile profile)
        {
            profile.CreateMap<TblDocumentHistory, DocumentHistoryDto>().ReverseMap();
        }
    }
} 