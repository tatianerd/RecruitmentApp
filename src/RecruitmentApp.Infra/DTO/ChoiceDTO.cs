using System;

namespace RecruitmentApp.Infra.DTO
{
    internal class ChoiceDTO
    {
        public int ChoiceId { get; set; }

        public string ChoiceDescription { get; set; }

        public DateTime Created { get; set; }
    }
}
