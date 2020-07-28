using Microsoft.AspNetCore.Mvc;
using QuizzyAPI.Domain;
using QuizzyAPI.Dtos;
using QuizzyAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizzyAPI.Controllers
{
    [ApiController]
    [Route("api/questions/")]
    public class QuestionController:ControllerBase
    {
        private readonly IEntityRepository<Question> repository;

        public QuestionController(IEntityRepository<Question> repository)
        {
            this.repository = repository;
        }
        /// <summary>
        /// collects an object use to create a question
        /// </summary>
        /// <param name="questionDto"></param>
        /// <returns>question created </returns>
        [HttpPost]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public IActionResult Create(CreationQuestionDto questionDto)
        {
           var q= new Question();

           repository.Add(q);
            return StatusCode(201, q);
        }
        

    }
}
