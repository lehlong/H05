using AutoMapper;
using Common;
using H05.BUSINESS.Common;
using H05.BUSINESS.Dtos.MD;
using H05.BUSINESS.Dtos.WH;
using H05.BUSINESS.Services.MD;
using H05.CORE;
using H05.CORE.Entities.MD;
using H05.CORE.Entities.WH;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H05.BUSINESS.Services.WH
{
    public interface IWarehouseService : IGenericService<TblMdWH, WarehouseDto>
    {
        Task<byte[]> Export(BaseMdFilter filter);
    }
    public class WarehouseService(AppDbContext dbContext, IMapper mapper) : GenericService<TblMdWH, WarehouseDto>(dbContext, mapper), IWarehouseService
    {
        public override async Task<PagedResponseDto> Search(BaseFilter filter)
        {
            try
            {
                var query = _dbContext.TblMdWH.AsQueryable();
                if (!string.IsNullOrWhiteSpace(filter.KeyWord))
                {
                    query = query.Where(x => x.Iwerk.Contains(filter.KeyWord) ||
                                          x.Werk.Contains(filter.KeyWord) ||
                                          x.WerkTxt.Contains(filter.KeyWord));
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
                var query = _dbContext.TblMdWH.AsQueryable();
                if (!string.IsNullOrWhiteSpace(filter.KeyWord))
                {
                    query = query.Where(x => x.Werk.Contains(filter.KeyWord));
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
