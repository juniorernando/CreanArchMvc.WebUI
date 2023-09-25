using AutoMapper;
using CleanArchMvc.Application.DTOs;
using CleanArchMvc.Application.Interfaces;
using CleanArchMvc.Domain.Entities;
using CleanArchMvc.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchMvc.Application.Services
{
    internal class CategoryService : ICategoryService 
    {
        private ICategoryRepository _category;
        private object _categoryRepository;
        private readonly IMapper _mapper;
        public CategoryService(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _category = categoryRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<CategoryDTO>> GetCategories()
        {
            var categoriesEntity = await _category.GetCategories();
            return _mapper.Map<IEnumerable<CategoryDTO>>(categoriesEntity);
        }

        public async Task<CategoryDTO> GetById(int? id)
        {
            var categoryEntity = await _category.GetById(id);
            return _mapper.Map<CategoryDTO>(categoryEntity);
        }

        public async Task Add(CategoryDTO categoryDto)
        {
            var categoryEntity = _mapper.Map<Category>(categoryDto);
            await _category.Create(categoryEntity);
        }

        public async Task Update(CategoryDTO categoryDto)
        {
            var categoryEntity = _mapper.Map<Category>(categoryDto);
            await _category.Update(categoryEntity);
        }

        public async Task Remove(int? id)
        {
            var categoryEntity = _category.GetById(id).Result;
            await _category.Remove(categoryEntity);
        }
    }
}
