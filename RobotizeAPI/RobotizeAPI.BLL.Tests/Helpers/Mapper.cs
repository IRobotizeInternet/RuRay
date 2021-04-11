using AutoMapper;
using RobotizeAPI.BLL.Mappings;

namespace RobotizeAPI.BLL.Tests.Helpers
{
    public static class Mapper
    {
        public static IMapper GetAutoMapper()
        {
            var mockMapper = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new CarsMapping());

            });
            var mapper = mockMapper.CreateMapper();
            return mapper;
        }
    }
}
