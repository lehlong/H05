using AutoMapper;
using Common;
using H05.CORE.Entities.MD;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace H05.BUSINESS.Dtos.MD
{
    public class EquipDocDto : BaseMdTemDto, IMapFrom, IDto
    {
        [JsonIgnore]
        [Description("STT")]
        public int OrdinalNumber { get; set; }
        [Key]
        [Description("Mã")]
        public string Id { get; set; }
        [Description("Mã thiết bị")]
        public string Equnr { get; set; } = null!;
        [Description("Loại tài liệu")]
        public string? Doctype { get; set; }
        [Description("Loại tệp")]
        public string? Filetype { get; set; }
        [Description("Tên tệp")]
        public string? Filename { get; set; }
        [Description("Kích thước tệp")]
        public int? Filesize { get; set; }
        [Description("Đường dẫn")]
        public string? Path { get; set; }
        [Description("Trạng thái")]
        public string State { get => this.IsActive == true ? "Đang hoạt động" : "Khóa"; }
        
        public void Mapping(Profile profile)
        {
            profile.CreateMap<TblMdEquipDoc, EquipDocDto>().ReverseMap();
        }
    }
} 