using AutoMapper;
using Common;
using H05.CORE.Entities;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace H05.BUSINESS.Dtos
{
    public class StorageBoxDto : IMapFrom, IDto
    {
        [Key]
        public long Id { get; set; }
        public string? BoxCode { get; set; }
        public string? Name { get; set; }
        public string? Location { get; set; }
        public int? Capacity { get; set; }
        public int? UsedCapacity { get; set; }
        public string? Description { get; set; }
        public short? Status { get; set; }
        public DateTimeOffset? CreatedAt { get; set; }
        public DateTimeOffset? UpdatedAt { get; set; }
        public long? CreatedBy { get; set; }
        public long? UpdatedBy { get; set; }
        
        public void Mapping(Profile profile)
        {
            profile.CreateMap<TblStorageBox, StorageBoxDto>().ReverseMap();
        }
    }
} 