using AutoMapper;
using Common;
using H05.CORE.Entities;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace H05.BUSINESS.Dtos
{
    public class DocumentViewerDto : IMapFrom, IDto
    {
        [Key]
        public int Id { get; set; }
        public string? DocumentType { get; set; }
        public int? OutgoingDocumentId { get; set; }
        public int? ViewerId { get; set; }
        public DateTimeOffset? CreatedAt { get; set; }
        
        public void Mapping(Profile profile)
        {
            profile.CreateMap<TblDocumentViewer, DocumentViewerDto>().ReverseMap();
        }
    }
} 