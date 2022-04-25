using System;

namespace RecruitmentApp.Infra.DTO
{
    public class QuestionDTO
    {
        public int QuestionId { get; set; }

        public string QuestionDescription { get; set; }

        public DateTime Created { get; set; }

        public string ImageUrl { get; set; }

        public string ThumbnailUrl { get; set; }
    }
}
