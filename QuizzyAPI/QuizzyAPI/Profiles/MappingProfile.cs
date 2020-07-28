using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using QuizzyAPI.Domain;
using QuizzyAPI.Dtos;

namespace QuizzyAPI.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Question, CreationQuestionDto>().ReverseMap();
            CreateMap<Answer, CreateAnswerDto>().ReverseMap();
            CreateMap<Category, CreateCategoryDto>().ReverseMap();
           
        }
    }
}