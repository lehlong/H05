using AutoMapper;
using Common;
using H05.BUSINESS.Common;
using H05.BUSINESS.Dtos;
using H05.CORE;
using H05.CORE.Entities;

namespace H05.BUSINESS.Services
{
    public interface IOrganizationService : IGenericService<TblOrganization, OrganizationDto>
    {
    }
    public class OrganizationService(AppDbContext dbContext, IMapper mapper) : GenericService<TblOrganization, OrganizationDto>(dbContext, mapper), IOrganizationService
    {
        public override async Task<PagedResponseDto> Search(BaseFilter filter)
        {
            try
            {
                var query = _dbContext.TblOrganization.AsQueryable();
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