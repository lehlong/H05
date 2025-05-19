using AutoMapper;
using Common;
using H05.CORE.Entities.TRAN;
using System.ComponentModel.DataAnnotations;

namespace H05.BUSINESS.Dtos.TRAN
{
    public class NotiAttDto : BaseMdDto, IMapFrom, IDto
    {
        [Key]
        public string Id { get; set; } = null!;
        public string Qmnum { get; set; } = null!;
        public string? FileType { get; set; }
        public int? FileSize { get; set; }
        public string? Path { get; set; }
        public string State { get => this.IsActive == true ? "Đang hoạt động" : "Khóa"; }
        
        public void Mapping(Profile profile)
        {
            profile.CreateMap<TblTranNotiAtt, NotiAttDto>().ReverseMap();
        }
    }
} 