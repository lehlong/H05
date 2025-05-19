using AutoMapper;
using Common;
using H05.CORE.Entities;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace H05.BUSINESS.Dtos
{
    public class DocumentNumberDto : IMapFrom, IDto
    {
        [Key]
        public long Id { get; set; }
        public int? DocumentBookId { get; set; }
        public string? DocumentType { get; set; }
        public int? DocumentNumber { get; set; }
        public string? DocumentCode { get; set; }
        public string? SubNumber { get; set; }
        public bool? IsUsed { get; set; }
        public bool? IsCanceled { get; set; }
        public string? CanceledReason { get; set; }
        public int? RequestedById { get; set; }
        public int? ApprovedById { get; set; }
        public DateTime? RequestedAt { get; set; }
        public DateTime? ApprovedAt { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        
        public void Mapping(Profile profile)
        {
            profile.CreateMap<TblDocumentNumber, DocumentNumberDto>().ReverseMap();
        }
    }
} 