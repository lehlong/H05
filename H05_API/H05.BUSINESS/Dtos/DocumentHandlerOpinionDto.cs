using AutoMapper;
using Common;
using H05.CORE.Entities;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace H05.BUSINESS.Dtos
{
    public class DocumentHandlerOpinionDto : IMapFrom, IDto
    {
        [Key]
        public long Id { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public long? DocumentHandleId { get; set; }
        public long? OpinionId { get; set; }
        
        public void Mapping(Profile profile)
        {
            profile.CreateMap<TblDocumentHandlerOpinion, DocumentHandlerOpinionDto>().ReverseMap();
        }
    }
} 