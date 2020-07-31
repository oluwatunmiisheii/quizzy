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
    public class QuestionController : ControllerBase
    {
        private readonly IEntityRepository<Question> repository;
        private readonly IMapper mapper;

        public QuestionController(IEntityRepository<Question> repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }
        /// <summary>
        /// gets all available questions
        /// </summary>
        /// <returns>returns all the questions that are available</returns>
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
        /// <summary>
        /// get a question by Id
        /// </summary>
        /// <param name="id">id of the question needed</param>
        /// <returns>question with the id specified</returns>
        [HttpGet("{id}")]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public IActionResult Get(Guid? id)
        {
            if (id != null)
            {
                var question = repository.Get(id);
                if (question != null) 
                { 
                var questionDto = mapper.Map<UpdateQuestionDto>(question);
                return Ok(questionDto);
                }
                return StatusCode(404);
            }
            return BadRequest();
        }


        /// <summary>
        /// create a question
        /// </summary>
        /// <param name="questionDto"> question to create</param>
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

        /// <summary>
        /// update question
        /// </summary>
        /// <param name="id">parameter to identify question</param>
        /// <param name="questionDto">queston to be updated </param>
        /// <returns> updated question </returns>
        [HttpPut("{id}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public IActionResult Edit(Guid id,UpdateQuestionDto questionDto)
        {
            if (ModelState.IsValid && id== questionDto.Id)
            {
                var question = mapper.Map<Question>(questionDto);
                repository.Update(question);
                return StatusCode(200, questionDto);
            }
            return BadRequest();
        }
        /// <summary>
        /// delete question
        /// </summary>
        /// <param name="id">parameter that identify question you are to delete </param>
        /// <returns>status code ok 200 on success</returns>
        [HttpDelete("{id}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public IActionResult Delete(Guid? id)
        {
            if (ModelState.IsValid && id != null)
            {
                var question = repository.Get(id);
                if (question != null)
                {
                    repository.Remove(question);
                    return StatusCode(200);
                }
            }
            return BadRequest();
        }

    }
}
