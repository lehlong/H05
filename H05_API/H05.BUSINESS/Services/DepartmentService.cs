using AutoMapper;
using Common;
using H05.BUSINESS.Common;
using H05.BUSINESS.Dtos;
using H05.CORE;
using H05.CORE.Entities;

namespace H05.BUSINESS.Services
{
    public interface IDepartmentService : IGenericService<TblDepartment, DepartmentDto>
    {
    }
    public class DepartmentService(AppDbContext dbContext, IMapper mapper) : GenericService<TblDepartment, DepartmentDto>(dbContext, mapper), IDepartmentService
    {
        public override async Task<PagedResponseDto> Search(BaseFilter filter)
        {
            try
            {
                var query = _dbContext.TblDepartment.AsQueryable();
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
