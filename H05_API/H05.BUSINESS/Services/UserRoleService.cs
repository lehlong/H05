using AutoMapper;
using Common;
using H05.BUSINESS.Common;
using H05.BUSINESS.Dtos;
using H05.CORE;
using H05.CORE.Entities;

namespace H05.BUSINESS.Services
{
    public interface IUserRoleService : IGenericService<TblUserRole, UserRoleDto>
    {
    }
    public class UserRoleService(AppDbContext dbContext, IMapper mapper) : GenericService<TblUserRole, UserRoleDto>(dbContext, mapper), IUserRoleService
    {
        public override async Task<PagedResponseDto> Search(BaseFilter filter)
        {
            try
            {
                var query = _dbContext.TblUserRole.AsQueryable();
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