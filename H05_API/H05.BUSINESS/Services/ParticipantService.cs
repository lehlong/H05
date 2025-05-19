using AutoMapper;
using Common;
using H05.BUSINESS.Common;
using H05.BUSINESS.Dtos;
using H05.CORE;
using H05.CORE.Entities;

namespace H05.BUSINESS.Services
{
    public interface IParticipantService : IGenericService<TblParticipant, ParticipantDto>
    {
    }
    public class ParticipantService(AppDbContext dbContext, IMapper mapper) : GenericService<TblParticipant, ParticipantDto>(dbContext, mapper), IParticipantService
    {
        public override async Task<PagedResponseDto> Search(BaseFilter filter)
        {
            try
            {
                var query = _dbContext.TblParticipant.AsQueryable();
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