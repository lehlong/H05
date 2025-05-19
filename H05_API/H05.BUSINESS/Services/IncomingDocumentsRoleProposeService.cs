using AutoMapper;
using Common;
using H05.BUSINESS.Common;
using H05.BUSINESS.Dtos;
using H05.CORE;
using H05.CORE.Entities;

namespace H05.BUSINESS.Services
{
    public interface IIncomingDocumentsRoleProposeService : IGenericService<TblIncomingDocumentsRolePropose, IncomingDocumentsRoleProposeDto>
    {
    }
    public class IncomingDocumentsRoleProposeService(AppDbContext dbContext, IMapper mapper) : GenericService<TblIncomingDocumentsRolePropose, IncomingDocumentsRoleProposeDto>(dbContext, mapper), IIncomingDocumentsRoleProposeService
    {
        public override async Task<PagedResponseDto> Search(BaseFilter filter)
        {
            try
            {
                var query = _dbContext.TblIncomingDocumentsRolePropose.AsQueryable();
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