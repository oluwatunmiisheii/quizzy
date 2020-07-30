using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizzyAPI.Domain
{
    public class Question
    {
        public Guid Id { get; set; }
        public string Text { get; set; }
        public Guid? CategoryId { get; set; }
        public ICollection<Answer> Answers { get; set; }
    }
}
