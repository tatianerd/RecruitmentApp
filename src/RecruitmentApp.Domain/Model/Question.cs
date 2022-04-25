using System;

namespace RecruitmentApp.Domain.Model
{
    public class Question
    {
        public int QuestionId { get; set; }

        public string QuestionDescription { get; set; }

        public DateTime Created { get; set; }

        public string ImageUrl { get; set; }

        public string ThumbnailUrl { get; set; }
    }
}
