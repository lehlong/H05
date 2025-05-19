using AutoMapper;
using Common;
using H05.CORE.Entities;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace H05.BUSINESS.Dtos
{
    public class RelatedDocumentDto : IMapFrom, IDto
    {
        [Key]
        public long Id { get; set; }
        public long? WorkRecordId { get; set; }
        public string? DocumentType { get; set; }
        public long? IncomingDocumentId { get; set; }
        public long? OutgoingDocumentId { get; set; }
        public DateTimeOffset? DocumentDate { get; set; }
        public string? Notes { get; set; }
        
        public void Mapping(Profile profile)
        {
            profile.CreateMap<TblRelatedDocument, RelatedDocumentDto>().ReverseMap();
        }
    }
} 