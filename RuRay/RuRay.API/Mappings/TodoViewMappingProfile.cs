using AutoMapper;

namespace RuRay.API.Mappings
{
    /// <summary>
    /// Defines the <see cref="TodoViewMappings" />.
    /// </summary>
    public class TodoViewMappings : Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TodoViewMappings"/> class.
        /// </summary>
        public TodoViewMappings()
        {
            CreateMap<BLL.Models.Todo, Models.Todo>()
                .ForMember(d => d.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(d => d.Title, opt => opt.MapFrom(src => src.Title))
                .ForMember(d => d.Completed, opt => opt.MapFrom(src => src.Completed));

            CreateMap<Models.Todo, BLL.Models.Todo>()
                .ForMember(d => d.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(d => d.Title, opt => opt.MapFrom(src => src.Title))
                .ForMember(d => d.Completed, opt => opt.MapFrom(src => src.Completed));
        }
    }
}
