using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuizzyAPI.Dtos
{
    public class CreateAnswerDto
    {
        [Required]
        public string Text { get; set; }
        public bool IsCorrect { get; set; }
        [Required]
        public Guid? QuestionId { get; set; }


    }
}
