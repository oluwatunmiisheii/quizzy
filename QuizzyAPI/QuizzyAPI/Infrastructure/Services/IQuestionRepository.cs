using QuizzyAPI.Domain;
using QuizzyAPI.Infrastructure.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizzyAPI.Infrastructure.Services
{
    public interface IQuestionRepository:IEntityRepository<Question>
    {

        public bool IsExist(Guid id);
        
    }
}
