﻿using AutoMapper;
using Common;
using H05.BUSINESS.Common;
using H05.BUSINESS.Dtos.MD;
using H05.BUSINESS.Filter.MD;
using H05.CORE;
using H05.CORE.Entities.MD;

namespace H05.BUSINESS.Services.MD
{
    public interface IEquipService : IGenericService<TblMdEquip, EquipDto>
    {
        Task<PagedResponseDto> Search(EquipFilter filter);
        Task<byte[]> Export(BaseMdFilter filter);
    }
    public class EquipService(AppDbContext dbContext, IMapper mapper) : GenericService<TblMdEquip, EquipDto>(dbContext, mapper), IEquipService
    {
        public async Task<PagedResponseDto> Search(EquipFilter filter)
        {
            try
            {
                var query = _dbContext.TblMdEquip.AsQueryable();
                if (!string.IsNullOrWhiteSpace(filter.KeyWord))
                {
                    query = query.Where(x => x.Eqktx.ToString().Contains(filter.KeyWord));
                }

                if (!string.IsNullOrWhiteSpace(filter.Tplnr))
                {
                    query = query.Where(x => x.Tplnr == filter.Tplnr);
                }

                if (!string.IsNullOrWhiteSpace(filter.Eqart))
                {
                    query = query.Where(x => x.Eqart == filter.Eqart);
                }

                if (filter.IsActive.HasValue)
                {
                    query = query.Where(x => x.IsActive == filter.IsActive);
                }
                return await Paging(query, filter);

            }
            catch (Exception ex)
            {
                Status = false;
                Exception = ex;
                return null;
            }
        }
        public async Task<byte[]> Export(BaseMdFilter filter)
        {
            try
            {
                var query = _dbContext.TblMdEquip.AsQueryable();
                if (!string.IsNullOrWhiteSpace(filter.KeyWord))
                {
                    query = query.Where(x => x.Class.Contains(filter.KeyWord));
                }
                if (filter.IsActive.HasValue)
                {
                    query = query.Where(x => x.IsActive == filter.IsActive);
                }
                var data = await base.GetAllMd(query, filter);
                int i = 1;
                data.ForEach(x =>
                {
                    x.OrdinalNumber = i++;
                });
                return await ExportExtension.ExportToExcel(data);
            }
            catch (Exception ex)
            {
                Status = false;
                Exception = ex;
                return null;
            }
        }
    }
}
