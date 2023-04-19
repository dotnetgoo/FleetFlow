using FleetFlow.Domain.Entities;
using FleetFlow.Service.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FleetFlow.Service.Interfaces
{
    public interface IProductService
    {
        public Task<Product> CreatAsync(ProductCreationDto creationDto);
        public Task<bool> DeleteAsync(long id);
        public Task<Product> UpdateAsync(long id,ProductCreationDto productCreationDto);
        public Task<IEnumerable<Product>> GetAllAsync();
        public Task<Product> GetByIdAsync(long id);

    }
}
