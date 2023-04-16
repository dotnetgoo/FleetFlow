using FleetFlow.Domain.Congirations;
using FleetFlow.Service.DTOs;

namespace FleetFlow.Service.Interfaces;

public interface IMerchantService
{
    Task<MerchantForResultDto> AddAsync(MerchantForCreationDto dto);
    Task<MerchantForResultDto> ModifyAsync(long id, MerchantForCreationDto dto);
    Task<bool> RemoveAsync(long id);
    Task<MerchantForResultDto> RetrieveByIdAsync(long id);
    Task<IEnumerable<MerchantForResultDto>> RetrieveAllAsync(PaginationParams @params);
}