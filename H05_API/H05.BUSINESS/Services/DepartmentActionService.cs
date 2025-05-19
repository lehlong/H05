using AutoMapper;
using Common;
using H05.BUSINESS.Common;
using H05.BUSINESS.Dtos;
using H05.CORE;
using H05.CORE.Entities;

namespace H05.BUSINESS.Services
{
    public interface IDepartmentActionService : IGenericService<TblDepartmentAction, DepartmentActionDto>
    {
    }
    public class DepartmentActionService(AppDbContext dbContext, IMapper mapper) : GenericService<TblDepartmentAction, DepartmentActionDto>(dbContext, mapper), IDepartmentActionService
    {
        public override async Task<PagedResponseDto> Search(BaseFilter filter)
        {
            try
            {
                var query = _dbContext.TblDepartmentAction.AsQueryable();
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