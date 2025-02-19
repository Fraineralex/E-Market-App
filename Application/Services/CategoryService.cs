﻿using EMarketApp.Core.Application.Interfaces.Repositories;
using EMarketApp.Core.Application.Interfaces.Services;
using EMarketApp.Core.Application.ViewModels.Categories;
using EMarketApp.Core.Domain.Entities;
using System;

namespace EMarketApp.Core.Application.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoriesRepository _categoryRepository;

        public CategoryService(ICategoriesRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public class Objet
        {
            public int UserId { get; set; }
        }

        public async Task<List<CategoryViewModel>> GetAllViewModel()
        {
            var categoriesList = await _categoryRepository.GetAllWithIncludeAsync(new List<string> { "Ads" });
            return categoriesList.Select(category => new CategoryViewModel
            {
                Id = category.Id,
                Name = category.Name,
                Description = category.Description,
                AdsQuantity = category.Ads.Count(),
                UsersQuantity =
                (from item in category.Ads
                 group item by new { item.UserId } into g
                 select new Objet()
                 {
                     UserId = g.Key.UserId

                 }).Count()

            }).ToList();
        }

        public async Task<SaveCategoryViewModel> Add(SaveCategoryViewModel vm)
        {
            Categories category = new();
            category.Name = vm.Name;
            category.Description = vm.Description;

            category = await _categoryRepository.AddAsync(category);

            SaveCategoryViewModel categoryVm = new();
            categoryVm.Id = category.Id;
            categoryVm.Name = category.Name;
            categoryVm.Description = category.Description;

            return categoryVm;
        }

        public async Task Update(SaveCategoryViewModel vm)
        {
            Categories category = await _categoryRepository.GetByIdAsync(vm.Id);
            category.Id = vm.Id;
            category.Name = vm.Name;
            category.Description = vm.Description;

            await _categoryRepository.UpdateAsync(category);
        }

        public async Task Delete(int id)
        {
            var category = await _categoryRepository.GetByIdAsync(id);
            await _categoryRepository.DeleteAsync(category);
        }

        public async Task<SaveCategoryViewModel> GetSaveViewModelById(int id)
        {
            var category = await _categoryRepository.GetByIdAsync(id);

            SaveCategoryViewModel vm = new();
            vm.Id = category.Id;
            vm.Name = category.Name;
            vm.Description = category.Description;

            return vm;
        }
    }
}
