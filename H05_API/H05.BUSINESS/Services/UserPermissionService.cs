using AutoMapper;
using Common;
using H05.BUSINESS.Common;
using H05.BUSINESS.Dtos;
using H05.CORE;
using H05.CORE.Entities;

namespace H05.BUSINESS.Services
{
    public interface IUserPermissionService : IGenericService<TblUserPermission, UserPermissionDto>
    {
    }
    public class UserPermissionService(AppDbContext dbContext, IMapper mapper) : GenericService<TblUserPermission, UserPermissionDto>(dbContext, mapper), IUserPermissionService
    {
        public override async Task<PagedResponseDto> Search(BaseFilter filter)
        {
            try
            {
                var query = _dbContext.TblUserPermission.AsQueryable();
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