using AutoMapper;
using Common;
using H05.CORE.Entities;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace H05.BUSINESS.Dtos
{
    public class StorageDocumentDetailDto : IMapFrom, IDto
    {
        [Key]
        public long Id { get; set; }
        public long? StorageRecordId { get; set; }
        public string? DocumentType { get; set; }
        public long? DocumentId { get; set; }
        public string? DocumentCode { get; set; }
        public string? DocumentName { get; set; }
        public string? Notes { get; set; }
        public DateTimeOffset? CreatedAt { get; set; }
        public long? CreatedBy { get; set; }
        
        public void Mapping(Profile profile)
        {
            profile.CreateMap<TblStorageDocumentDetail, StorageDocumentDetailDto>().ReverseMap();
        }
    }
} 