using AutoMapper;
using Common;
using H05.CORE.Entities;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace H05.BUSINESS.Dtos
{
    public class RelatedOutgoingDocumentDto : IMapFrom, IDto
    {
        [Key]
        public long Id { get; set; }
        public long? WorkRecordId { get; set; }
        public long? OutgoingDocumentId { get; set; }
        public DateTime? DocumentDate { get; set; }
        public string? Notes { get; set; }
        public DateTime? CreatedAt { get; set; }
        public long? CreatedBy { get; set; }
        
        public void Mapping(Profile profile)
        {
            profile.CreateMap<TblRelatedOutgoingDocument, RelatedOutgoingDocumentDto>().ReverseMap();
        }
    }
} 