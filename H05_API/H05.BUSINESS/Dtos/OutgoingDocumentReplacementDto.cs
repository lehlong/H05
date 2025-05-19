using AutoMapper;
using Common;
using H05.CORE.Entities;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace H05.BUSINESS.Dtos
{
    public class OutgoingDocumentReplacementDto : IMapFrom, IDto
    {
        [Key]
        public int Id { get; set; }
        public int? DocumentId { get; set; }
        public int? ReplacedDocumentId { get; set; }
        public DateTime? ReplacementDate { get; set; }
        public string? ReplacementReason { get; set; }
        public int? ReplacedBy { get; set; }
        
        public void Mapping(Profile profile)
        {
            profile.CreateMap<TblOutgoingDocumentReplacement, OutgoingDocumentReplacementDto>().ReverseMap();
        }
    }
} 