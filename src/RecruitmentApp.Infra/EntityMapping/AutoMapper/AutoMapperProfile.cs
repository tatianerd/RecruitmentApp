using AutoMapper;
using RecruitmentApp.Domain.Model;
using RecruitmentApp.Infra.DTO;

namespace RecruitmentApp.Infra.EntityMapping.AutoMapper
{
    public  class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<QuestionDTO, Question>()
                .ForMember(dest => dest.QuestionId, opt => opt.MapFrom(src => src.QuestionId))
                .ForMember(dest => dest.QuestionDescription, opt => opt.MapFrom(src => src.QuestionDescription))
                .ForMember(dest => dest.Created, opt => opt.MapFrom(src => src.Created))
                .ForMember(dest => dest.ImageUrl, opt => opt.MapFrom(src => src.ImageUrl))
                .ForMember(dest => dest.ThumbnailUrl, opt => opt.MapFrom(src => src.ThumbnailUrl));
        }
    }
}
