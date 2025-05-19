﻿using H05.CORE.Entities.AD;
using AutoMapper;
using Common;

namespace H05.BUSINESS.Dtos.AD
{
    public class MenuRightDto
    {
        public string MenuId { get; set; }

        public string RightId { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<TblAdMenuRight, MenuRightDto>().ReverseMap();
        }
    }

    public class MenuRightUpdateMenuDto : IMapFrom, IDto
    {
        public string RightId { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<TblAdMenuRight, MenuRightUpdateMenuDto>().ReverseMap();
        }
    }
}
