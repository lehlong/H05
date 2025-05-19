using AutoMapper;
using Common;
using H05.CORE.Entities.MD;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace H05.BUSINESS.Dtos.MD
{
    public class EquipClassDto : BaseMdDto, IMapFrom, IDto
    {
        [JsonIgnore]
        [Description("STT")]
        public int OrdinalNumber { get; set; }
        [Key]
        [Description("Mã thiết bị")]
        public string Equnr { get; set; } = null!;
        [Description("Lớp")]
        public string? Class { get; set; }
        [Description("Ngày hiệu lực")]
        public DateTime? Adatu { get; set; }
        [Description("Tên phiên bản")]
        public string? Vname { get; set; }
        [Description("Ngày phiên bản")]
        public DateTime? Vdatu { get; set; }
        [Description("Ngày bắt đầu")]
        public DateTime? Vondt { get; set; }
        [Description("Ngày kết thúc")]
        public DateTime? Bisdt { get; set; }
        [Description("Trạng thái")]
        public string State { get => this.IsActive == true ? "Đang hoạt động" : "Khóa"; }
        
        public void Mapping(Profile profile)
        {
            profile.CreateMap<TblMdEquipClass, EquipClassDto>().ReverseMap();
        }
    }
} 