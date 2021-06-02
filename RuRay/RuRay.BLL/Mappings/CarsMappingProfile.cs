using System;
using AutoMapper;
using RuRay.BLL.Models;
using RuRay.DAL.MySql.Models;

namespace RuRay.BLL.Mappings
{
    /// <summary>
    /// Defines the <see cref="CarsMapping" />.
    /// </summary>
    public class CarsMapping : Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CarsMapping"/> class.
        /// </summary>
        public CarsMapping()
        {
            CreateMap<Car, CarEntity>()
                .ForMember(d => d.Id, opt => opt.MapFrom(src => src.Id.ToString()))
                .ForMember(d => d.ModelName, opt => opt.MapFrom(src => src.ModelName))
                .ForMember(d => d.CarType, opt => opt.MapFrom(src => (int)src.CarType))
                .ForMember(d => d.CreatedOn, opt => opt.MapFrom(src => src.CreatedOn))
                .ForMember(d => d.ModifiedOn, opt => opt.MapFrom(src => src.ModifiedOn));

            CreateMap<CarEntity, Car>()
                .ForMember(d => d.Id, opt => opt.MapFrom(src => Guid.Parse(src.Id)))
                .ForMember(d => d.ModelName, opt => opt.MapFrom(src => src.ModelName))
                .ForMember(d => d.CarType, opt => opt.MapFrom(src => (CarType)src.CarType))
                .ForMember(d => d.CreatedOn, opt => opt.MapFrom(src => src.CreatedOn))
                .ForMember(d => d.ModifiedOn, opt => opt.MapFrom(src => src.ModifiedOn));
        }
    }
}
