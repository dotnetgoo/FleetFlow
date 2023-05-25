﻿using FleetFlow.Domain.Congirations;
using FleetFlow.Service.DTOs.Discounts;

namespace FleetFlow.Service.Interfaces.Products;

public interface IDiscountService
{
    Task<DiscountResultDto> AddAsync(DiscountCreationDto dto);
    Task<DiscountResultDto> ModifyAsync(DiscountUpdateDto dto);
    Task<DiscountResultDto> RetrieveAsync(long id);
    Task<IEnumerable<DiscountResultDto>> RetrieveAllAsync(PaginationParams @params);


    Task<bool> StopAsync(long id);
    Task<bool> StopByProductIdAsync(long productId);

}
