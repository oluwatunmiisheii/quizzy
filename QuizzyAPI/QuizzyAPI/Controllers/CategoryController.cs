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

        /// <summary>
        /// get all category 
        /// </summary>
        /// <returns>returns all category </returns>
        [HttpGet]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
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
        /// <summary>
        /// get category by Id 
        /// </summary>
        /// <param name="id">parameter use to get category</param>
        /// <returns>category object</returns>
        [HttpGet("{id}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public IActionResult Get(Guid? id)
        {
            if (id != null)
            {
                var category = repository.Get(id);
                var categoryDto = mapper.Map<CategoryDto>(category);

                if (categoryDto != null) return Ok(categoryDto);
                return StatusCode(404);
            }
            return BadRequest();
        }

        /// <summary>
        /// create a category
        /// </summary>
        /// <param name="categoryDto">category to be creaated </param>
        /// <returns>created category</returns>
        [HttpPost]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
       
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

        /// <summary>
        /// update category
        /// </summary>
        /// <param name="id">parameter used to identify category to update</param>
        /// <param name="categoryDto">category to be updated </param>
        /// <returns>updated category </returns>
        [HttpPut("{id}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public IActionResult Edit(Guid id, UpdateCategoryDto categoryDto)
        {
            if (ModelState.IsValid && id == categoryDto.Id)
            {
                var category = mapper.Map<Category>(categoryDto);
                repository.Update(category);
                return StatusCode(200);

            }
            return BadRequest();
        }

        /// <summary>
        /// delete category
        /// </summary>
        /// <param name="id"> parameter to identify answer </param>
        /// <returns>status code 200 Ok </returns>
        [HttpDelete("{id}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public IActionResult Delete(Guid? id)
        {
            if (ModelState.IsValid && id != null)
            {
                var category = repository.Get(id);
                if (category != null)
                {
                    repository.Remove(category);
                    return StatusCode(200);
                }
            }
            return BadRequest();
        }
    }
}
