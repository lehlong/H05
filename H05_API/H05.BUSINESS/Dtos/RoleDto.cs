using AutoMapper;
using Common;
using H05.CORE.Entities;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace H05.BUSINESS.Dtos
{
    public class RoleDto : IMapFrom, IDto
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Code { get; set; }
        public int? DepartmentId { get; set; }
        public string? Description { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public bool? CanSignDraft { get; set; }
        public bool? CanSignReport { get; set; }
        public bool? CanManageInfo { get; set; }
        public bool? CanTransferAny { get; set; }
        public bool? IsHiddenAccount { get; set; }
        public bool? CanReceiveInternal { get; set; }
        public bool? CanDelegate { get; set; }
        public bool? CanDirectCommand { get; set; }
        public bool? CanManageUnitBook { get; set; }
        public float? Order { get; set; }
        public string? RoleType { get; set; }
        
        public void Mapping(Profile profile)
        {
            profile.CreateMap<TblRole, RoleDto>().ReverseMap();
        }
    }
} 