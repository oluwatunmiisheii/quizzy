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
        [HttpGet("{id}")]
        public IActionResult Get(Guid? id)
        {
            if (id != null)
            {
               var ans= repository.GetOne(c => c.Id == id);
                if (ans != null) return Ok(ans);
               return StatusCode(404);
            }
            return BadRequest();
        }
        

        [HttpPost]
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
            }
            return BadRequest();
        }

        [HttpPost("addall")]
        public IActionResult AddAnswers(IEnumerable<CreateAnswerDto> answerDto)
        {
            if (ModelState.IsValid)
            {
                var answer = mapper.Map<IEnumerable<Answer>>(answerDto);
                repository.AddRange(answer);
            }
            return StatusCode(201, answerDto);
        }

        [HttpPut]
        public IActionResult Edit(UpdateAnswerDto answerDto)
        {
            if (ModelState.IsValid)
            {
                var answer = mapper.Map<Answer>(answerDto);
                repository.Update(answer);
            }
            return StatusCode(200);
        }
    }
}
