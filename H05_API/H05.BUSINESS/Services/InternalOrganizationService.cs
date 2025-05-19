using AutoMapper;
using Common;
using H05.BUSINESS.Common;
using H05.BUSINESS.Dtos;
using H05.CORE;
using H05.CORE.Entities;

namespace H05.BUSINESS.Services
{
    public interface IInternalOrganizationService : IGenericService<TblInternalOrganization, InternalOrganizationDto>
    {
    }
    public class InternalOrganizationService(AppDbContext dbContext, IMapper mapper) : GenericService<TblInternalOrganization, InternalOrganizationDto>(dbContext, mapper), IInternalOrganizationService
    {
        public override async Task<PagedResponseDto> Search(BaseFilter filter)
        {
            try
            {
                var query = _dbContext.TblInternalOrganization.AsQueryable();
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