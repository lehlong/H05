using AutoMapper;
using Common;
using H05.BUSINESS.Common;
using H05.BUSINESS.Dtos;
using H05.CORE;
using H05.CORE.Entities;

namespace H05.BUSINESS.Services
{
    public interface IDelegationService : IGenericService<TblDelegation, DelegationDto>
    {
    }
    public class DelegationService(AppDbContext dbContext, IMapper mapper) : GenericService<TblDelegation, DelegationDto>(dbContext, mapper), IDelegationService
    {
        public override async Task<PagedResponseDto> Search(BaseFilter filter)
        {
            try
            {
                var query = _dbContext.TblDelegation.AsQueryable();
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