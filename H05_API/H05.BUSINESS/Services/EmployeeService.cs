using AutoMapper;
using Common;
using H05.BUSINESS.Common;
using H05.BUSINESS.Dtos;
using H05.CORE;
using H05.CORE.Entities;

namespace H05.BUSINESS.Services
{
    public interface IEmployeeService : IGenericService<TblEmployee, EmployeeDto>
    {
    }
    public class EmployeeService(AppDbContext dbContext, IMapper mapper) : GenericService<TblEmployee, EmployeeDto>(dbContext, mapper), IEmployeeService
    {
        public override async Task<PagedResponseDto> Search(BaseFilter filter)
        {
            try
            {
                var query = _dbContext.TblEmployee.AsQueryable();
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