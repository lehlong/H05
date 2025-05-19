using AutoMapper;
using Common;
using H05.CORE.Entities;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace H05.BUSINESS.Dtos
{
    public class OutgoingDocumentTaskDto : IMapFrom, IDto
    {
        [Key]
        public int Id { get; set; }
        public int? DocumentId { get; set; }
        public int? TaskId { get; set; }
        public DateTimeOffset? CreatedAt { get; set; }
        
        public void Mapping(Profile profile)
        {
            profile.CreateMap<TblOutgoingDocumentTask, OutgoingDocumentTaskDto>().ReverseMap();
        }
    }
} 