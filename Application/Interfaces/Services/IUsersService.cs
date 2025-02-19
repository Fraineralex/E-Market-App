﻿using EMarketApp.Core.Application.ViewModels.Users;
using EMarketApp.Core.Domain.Entities;

namespace EMarketApp.Core.Application.Interfaces.Services
{
    public interface IUsersService : IGenericService<UserViewModel, SaveUserViewModel>
    {
        Task<UserViewModel> Login(LoginViewModel loginVm);
        Task<Users> GetAUserByUsernameAsync(string username);
    }
}
