using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using QuizzyAPI.Domain;
using QuizzyAPI.Dtos;
using QuizzyAPI.Infrastructure.Services;
using QuizzyAPI.Infrastructure.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizzyAPI.Controllers
{
    [ApiController]
    [Route("api/answers/")]
    public class AnswerController:ControllerBase
    {
        private readonly IEntityRepository<Answer> repository;
        private readonly IQuestionRepository questionRepository;
        private readonly IMapper mapper;

        public AnswerController(IEntityRepository<Answer> repository,IQuestionRepository questionRepository, IMapper mapper)
        {
            this.repository = repository;
            this.questionRepository = questionRepository;
            this.mapper = mapper;
        }

        
        [HttpGet]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> GetAll()
        {
                var answers = await repository.GetAll();
            if (answers != null && answers.Count() > 0)
            {
                var answersDto = mapper.Map<IEnumerable<AnswerDto>>(answers);
                return Ok(answersDto);
            }
                return StatusCode(404);
            
        }


        /// <summary>
        /// get answer by its id
        /// </summary>
        /// <param name="id">id of the answer </param>
        /// <returns> answer requested by id </returns>
        [HttpGet("{id}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public IActionResult Get(Guid? id)
        {
            if (id != null)
            {
               var ans= repository.Get(id);
                if (ans != null) return Ok(ans);
               return StatusCode(404);
            }
            return BadRequest();
        }
        
        /// <summary>
        /// create an answer
        /// </summary>
        /// <param name="answerDto">answer to add  </param>
        /// <returns>return the created answer </returns>
        [HttpPost]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public IActionResult Add(CreateAnswerDto answerDto)
        {
            if (ModelState.IsValid)
            {
                if (questionRepository.IsExist(answerDto.QuestionId))
                {
                    var answer = mapper.Map<Answer>(answerDto);
                    var ans = repository.Add(answer);
                    return StatusCode(201, ans);
                }
                return BadRequest("Invalid Question Id");
            }
            return BadRequest();
        }

        /// <summary>
        ///list of answers to be added 
        /// </summary>
        /// <param name="answerDto">answers to be added </param>
        /// <returns>returns all the answers created </returns>
        [HttpPost("addall")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]

        public IActionResult AddAnswers(IEnumerable<CreateAnswerDto> answerDto)
        {
            if (ModelState.IsValid)
            {
                var answer = mapper.Map<IEnumerable<Answer>>(answerDto);
                repository.AddRange(answer);
            }
            return StatusCode(201, answerDto);
        }

        /// <summary>
        /// update the answer with specified Id
        /// </summary>
        /// <param name="id">parameter to identify answer</param>
        /// <param name="answerDto">answer to update</param>
        /// <returns></returns>
        [HttpPut("{id}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public IActionResult Edit(Guid id, UpdateAnswerDto answerDto)
        {
            if (ModelState.IsValid && id==answerDto.Id )
            {
                var answer = mapper.Map<Answer>(answerDto);
                repository.Update(answer);
                return StatusCode(200);
            }
            return BadRequest();
        }
        /// <summary>
        /// delete answer
        /// </summary>
        /// <param name="id">parameter to identify answer </param>
        /// <returns>status code 200 Ok </returns>
        [HttpDelete("{id}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public IActionResult Delete(Guid? id)
        {
            if (ModelState.IsValid && id !=null)
            {
                var answer = repository.Get(id);
                if(answer != null)
                {
                    repository.Remove(answer);
                    return StatusCode(200);
                }
            }
            return BadRequest();
        }
    }
}
