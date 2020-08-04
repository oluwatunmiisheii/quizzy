using QuizzyAPI.Domain;
using QuizzyAPI.Infrastructure.Services.Services;
using QuizzyAPI.Infrastructure.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QuizzyAPI.Infrastructure.Data;

namespace QuizzyAPI.Infrastructure.Services
{
    public class QuestionRepository : EntityRepository<Question>, IQuestionRepository
    {
        private readonly DataContext context;

        public QuestionRepository(DataContext context):base(context)
        {
            this.context = context;
        }
        public bool IsExist(Guid? id)
        {
           return Entities.Any(c => c.Id == id);
        }
    }
}
