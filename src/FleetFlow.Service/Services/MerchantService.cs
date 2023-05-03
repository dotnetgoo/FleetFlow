using AutoMapper;
using FleetFlow.DAL.IRepositories;
using FleetFlow.Domain.Congirations;
using FleetFlow.Domain.Entities;
using FleetFlow.Service.DTOs.Merchant;
using FleetFlow.Service.Exceptions;
using FleetFlow.Service.Extentions;
using FleetFlow.Service.Interfaces;
using FleetFlow.Shared.Helpers;

namespace FleetFlow.Service.Services
{
    public class MerchantService : IMerchantService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;
        public MerchantService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            // Injected dependencies
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        /// <summary>
        /// Adds a new merchant to the database.
        /// </summary>
        /// <param name="dto">The DTO containing the merchant data to add.</param>
        /// <returns>The DTO of the added merchant.</returns>
        public async Task<MerchantForResultDto> AddAsync(MerchantForCreationDto dto)
        {
            // Check if merchant with the same email already exists
            var merchant = await this.unitOfWork.Merchants.SelectAsync(m => m.Email == dto.Email);
            if (merchant != null && !merchant.IsDeleted)
                throw new FleetFlowException(400, "Merchant already exists");

            // Map DTO to Entity and set CreatedAt to current time in UTC
            var mappedMerchant = this.mapper.Map<Merchant>(dto);
            mappedMerchant.CreatedAt = DateTime.UtcNow;

            // Add new merchant to database
            var addedMerchant = await this.unitOfWork.Merchants.InsertAsync(mappedMerchant);

            // Save changes to database
            await this.unitOfWork.SaveChangesAsync();

            // Map Entity to DTO and return
            return this.mapper.Map<MerchantForResultDto>(addedMerchant);
        }

        /// <summary>
        /// Removes a merchant from the database by ID.
        /// </summary>
        /// <param name="id">The ID of the merchant to remove.</param>
        /// <returns>True if the merchant was successfully removed.</returns>
        public async Task<bool> RemoveAsync(long id)
        {
            // Find merchant by id
            var merchant = await this.unitOfWork.Merchants.SelectAsync(m => m.Id == id);
            if (merchant == null || merchant.IsDeleted)
                throw new FleetFlowException(404, "Not found");

            // Delete merchant from database
            await this.unitOfWork.Merchants.DeleteAsync(m => m.Id == id);
            merchant.DeletedBy = HttpContextHelper.UserId;
            // Save changes to database
            await this.unitOfWork.SaveChangesAsync();

            // Return true to indicate success
            return true;
        }

        /// <summary>
        /// Modifies an existing merchant in the database.
        /// </summary>
        /// <param name="id">The ID of the merchant to modify.</param>
        /// <param name="dto">The DTO containing the modified merchant data.</param>
        /// <returns>The DTO of the modified merchant.</returns>
        public async Task<MerchantForResultDto> ModifyAsync(long id, MerchantForCreationDto dto)
        {
            // Find merchant by id
            var merchant = await this.unitOfWork.Merchants.SelectAsync(m => m.Id == id);
            if (merchant == null || merchant.IsDeleted)
                throw new FleetFlowException(404, "Not found");

            // Map DTO to Entity and set CreatedAt to current time in UTC
            var updatedMerchant = this.mapper.Map(dto, merchant);
            updatedMerchant.CreatedAt = DateTime.UtcNow;
            updatedMerchant.UpdatedBy = HttpContextHelper.UserId;
            // Save changes to database
            await this.unitOfWork.SaveChangesAsync();

            // Map Entity to DTO and return
            return this.mapper.Map<MerchantForResultDto>(updatedMerchant);
        }

        /// <summary>
        /// Retrieve all merchants from database with pagination params
        /// </summary>
        /// <param name="params"></param>
        /// <returns>DTOs of the retrieved merchants as IEnumerable </returns>
        public async Task<IEnumerable<MerchantForResultDto>> RetrieveAllAsync(PaginationParams @params)
        {
            // Retrieve all merchants with pagination parameters
            var merchants = this.unitOfWork.Merchants.SelectAll(includes: new string[] {"Address"})
                                .Where(m => m.IsDeleted == false)
                                .ToPagedList(@params).ToList();

            // Map entities to DTOs and return as IEnumerable
            return this.mapper.Map<IEnumerable<MerchantForResultDto>>(merchants);
        }

        /// <summary>
        /// Retrieve  merchant from database by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>The DTO of the  retrieved merchant</returns>
        /// <exception cref="FleetFlowException"></exception>
        public async Task<MerchantForResultDto> RetrieveByIdAsync(long id)
        {
            // Find merchant by id
            var merchant = await this.unitOfWork.Merchants.SelectAsync(m => m.Id == id);
            if (merchant == null || merchant.IsDeleted)
                throw new FleetFlowException(404, "Not found");

            // Map Entity to DTO and return
            return this.mapper.Map<MerchantForResultDto>(merchant);
        }
    }
}