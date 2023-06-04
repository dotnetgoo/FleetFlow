﻿using FleetFlow.Domain.Congirations;
using FleetFlow.Domain.Entities;
using FleetFlow.Service.DTOs.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FleetFlow.Service.Interfaces.Products
{
    public interface IProductService
    {
        public Task<ProductForResultDto> AddAsync(ProductForCreationDto dto);
        public Task<bool> RemoveAsync(long id);
        public Task<ProductForResultDto> ModifyAsync(long id, ProductForCreationDto dto);
        public Task<IEnumerable<ProductForResultDto>> RetrieveAllAsync(PaginationParams @params = null);
        public Task<ProductForResultDto> RetrieveByIdAsync(long id);

    }
}
