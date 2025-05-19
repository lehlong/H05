using AutoMapper;
using Common;
using H05.BUSINESS.Common;
using H05.BUSINESS.Dtos;
using H05.CORE;
using H05.CORE.Entities;

namespace H05.BUSINESS.Services
{
    public interface IBusinessUnitService : IGenericService<TblBusinessUnit, BusinessUnitDto>
    {
    }
    public class BusinessUnitService(AppDbContext dbContext, IMapper mapper) : GenericService<TblBusinessUnit, BusinessUnitDto>(dbContext, mapper), IBusinessUnitService
    {
        public override async Task<PagedResponseDto> Search(BaseFilter filter)
        {
            try
            {
                var query = _dbContext.TblBusinessUnit.AsQueryable();
                return await Paging(query, filter);
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