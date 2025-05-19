using AutoMapper;
using Common;
using H05.BUSINESS.Common;
using H05.BUSINESS.Dtos;
using H05.CORE;
using H05.CORE.Entities;

namespace H05.BUSINESS.Services
{
    public interface IPermissionActionService : IGenericService<TblPermissionAction, PermissionActionDto>
    {
    }
    public class PermissionActionService(AppDbContext dbContext, IMapper mapper) : GenericService<TblPermissionAction, PermissionActionDto>(dbContext, mapper), IPermissionActionService
    {
        public override async Task<PagedResponseDto> Search(BaseFilter filter)
        {
            try
            {
                var query = _dbContext.TblPermissionAction.AsQueryable();
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