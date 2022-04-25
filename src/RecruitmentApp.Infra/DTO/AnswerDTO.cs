using System;

namespace RecruitmentApp.Infra.DTO
{
    internal class AnswerDTO
    {
        public int AnswerId { get; set; }

        public int QuestionId { get; set; }

        public int ChoiceId { get; set; }   

        public int VoteCount { get; set; }

        public DateTime LastUpdated { get; set; }
    }
}
