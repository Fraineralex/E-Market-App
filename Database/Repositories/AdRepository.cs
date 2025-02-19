﻿using EMarketApp.Core.Application.Interfaces.Repositories;
using EMarketApp.Core.Domain.Entities;
using EMarketApp.Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace EMarketApp.Infrastructure.Persistence.Repositories
{
    public class AdRepository : GenericRepository<Ads>, IAdsRepository
    {
        private readonly ApplicationContext _dbContext;

        public AdRepository(ApplicationContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
