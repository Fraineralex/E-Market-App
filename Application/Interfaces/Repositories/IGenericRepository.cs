﻿using EMarketApp.Core.Domain.Entities;

namespace EMarketApp.Core.Application.Interfaces.Repositories
{
    public interface IGenericRepository<Entity> where Entity : class
    {
        Task<Entity> AddAsync(Entity entity);
        Task UpdateAsync(Entity entity);
        Task DeleteAsync(Entity entity);
        Task<List<Entity>> GetAllAsync();
        Task<Entity> GetByIdAsync(int id);

        Task<List<Entity>> GetAllWithIncludeAsync(List<string> properties);
    }
}
