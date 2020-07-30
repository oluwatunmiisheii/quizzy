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
    [Route("api/questions/")]
    public class QuestionController:ControllerBase
    {
        private readonly IEntityRepository<Question> repository;
        private readonly IMapper mapper;

        public QuestionController(IEntityRepository<Question> repository,IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var questions = await repository.GetAll();
            if (questions != null && questions.Count() > 0)
            {
                var questionsDto = mapper.Map<IEnumerable<UpdateQuestionDto>>(questions);
                return Ok(questionsDto);
            }
            return StatusCode(404);

        }

        [HttpGet("{id}")]
        public IActionResult Get(Guid? id)
        {
            if (id != null)
            {
                var question = repository.GetOne(c => c.Id == id);
                var questionDto = mapper.Map<UpdateQuestionDto>(question);

                if (questionDto != null) return Ok(questionDto);
                return StatusCode(404);
            }
            return BadRequest();
        }


        /// <summary>
        ///  create a question
        /// </summary>
        /// <param name="questionDto"> object to create a question</param>
        /// <returns>created question</returns>
        [HttpPost]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public IActionResult Add(CreationQuestionDto questionDto)
        {
            if (ModelState.IsValid)
            {
                var question = mapper.Map<Question>(questionDto);
                var ques = repository.Add(question);
                return StatusCode(201, ques);
            }
            return BadRequest();
        }

        [HttpPut]
        public IActionResult Edit(UpdateQuestionDto answerDto)
        {
            if (ModelState.IsValid)
            {
                var question = mapper.Map<Question>(answerDto);
                repository.Update(question);
                return StatusCode(201, answerDto);
            }
            return BadRequest();
        }

    }
}
