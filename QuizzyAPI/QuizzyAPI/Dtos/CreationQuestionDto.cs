using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuizzyAPI.Dtos
{
    public class CreationQuestionDto
    {
        [Required]
        [StringLength(350,MinimumLength =6)]
        public string Text { get; set; }
        public Guid? CategoryId { get; set; }
        public IEnumerable<AnswerForCreateQuestionDto> Answers { get; set; }
    }
}
