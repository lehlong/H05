using AutoMapper;
using Common;
using H05.CORE.Entities;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace H05.BUSINESS.Dtos
{
    public class OutgoingDocumentStatusHistoryDto : IMapFrom, IDto
    {
        [Key]
        public int Id { get; set; }
        public int? DocumentId { get; set; }
        public int? StatusId { get; set; }
        public DateTimeOffset? ChangedAt { get; set; }
        public int? ChangedBy { get; set; }
        public string? Comments { get; set; }
        
        public void Mapping(Profile profile)
        {
            profile.CreateMap<TblOutgoingDocumentStatusHistory, OutgoingDocumentStatusHistoryDto>().ReverseMap();
        }
    }
} 