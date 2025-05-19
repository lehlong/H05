using AutoMapper;
using Common;
using H05.BUSINESS.Common;
using H05.BUSINESS.Dtos;
using H05.CORE;
using H05.CORE.Entities;

namespace H05.BUSINESS.Services
{
    public interface IDepartmentPlansEmployeeService : IGenericService<TblDepartmentPlansEmployee, DepartmentPlansEmployeeDto>
    {
    }
    public class DepartmentPlansEmployeeService(AppDbContext dbContext, IMapper mapper) : GenericService<TblDepartmentPlansEmployee, DepartmentPlansEmployeeDto>(dbContext, mapper), IDepartmentPlansEmployeeService
    {
        public override async Task<PagedResponseDto> Search(BaseFilter filter)
        {
            try
            {
                var query = _dbContext.TblDepartmentPlansEmployee.AsQueryable();
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