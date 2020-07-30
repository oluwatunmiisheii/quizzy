using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using QuizzyAPI.Domain;
using QuizzyAPI.Dtos;
using QuizzyAPI.Infrastructure.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizzyAPI.Controllers
{
    [ApiController]
    [Route("api/category/")]
    public class CategoryController:ControllerBase
    {
        private readonly IEntityRepository<Category> repository;
        private readonly IMapper mapper;

        public CategoryController(IEntityRepository<Category> repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }


        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var categories =await repository.GetAll();
            if (categories != null && categories.Count() > 0)
            {
                var categoriesDto = mapper.Map<IEnumerable<CategoryDto>>(categories);

                return Ok(categoriesDto);
            }
            return StatusCode(404);

        }

        [HttpGet("{id}")]
        public IActionResult Get(Guid? id)
        {
            if (id != null)
            {
                var category = repository.GetOne(c => c.Id == id);
                var categoryDto = mapper.Map<CategoryDto>(category);

                if (categoryDto != null) return Ok(categoryDto);
                return StatusCode(404);
            }
            return BadRequest();
        }

        [HttpPost]
        public IActionResult Add(CreateCategoryDto categoryDto)
        {
            if (ModelState.IsValid)
            {
                var category = mapper.Map<Category>(categoryDto);
                var cat = repository.Add(category);
                return StatusCode(201, cat);

            }
            return BadRequest();
        }

        [HttpPut]
        public IActionResult Edit(UpdateCategoryDto categoryDto)
        {
            if (ModelState.IsValid)
            {
                var category = mapper.Map<Category>(categoryDto);
                repository.Update(category);
            }
            return StatusCode(200);
        }

    }
}
