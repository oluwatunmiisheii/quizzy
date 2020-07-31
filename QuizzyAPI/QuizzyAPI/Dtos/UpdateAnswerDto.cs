using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuizzyAPI.Dtos
{
    public class UpdateAnswerDto
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        public string Text { get; set; }
        public bool IsCorrect { get; set; }
        [Required]
        public Guid QuestionId { get; set; }

    }

    public class AnswerDto
    {
        public Guid Id { get; set; }
        public string Text { get; set; }
        public bool IsCorrect { get; set; }
        public Guid? QuestionId { get; set; }

    }

    public class AnswerForCreateQuestionDto
    {
        public string Text { get; set; }
        public bool IsCorrect { get; set; }

    }
}
