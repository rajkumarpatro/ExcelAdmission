using AutoMapper;
using DAL;
using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public static class Mapping
    {
        private static readonly Lazy<IMapper> Lazy = new Lazy<IMapper>(() =>
        {
            var config = new MapperConfiguration(cfg => {
                // This line ensures that internal properties are also mapped over.
                cfg.ShouldMapProperty = p => p.GetMethod.IsPublic || p.GetMethod.IsAssembly;
                cfg.AddProfile<MappingProfile>();
            });
            var mapper = config.CreateMapper();
            return mapper;
        });

        public static IMapper Mapper => Lazy.Value;
    }

    class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<TBL_COURSE, CourseModel>().ReverseMap();
            CreateMap<TBL_USERS, UsersModel>().ReverseMap();
            CreateMap<TBL_BRANCH, BranchModel>().ReverseMap();
            CreateMap<TBL_DESIGNATION, DesignationModel>().ReverseMap();
            CreateMap<TBL_SUBJECTS, SubjectModel>().ReverseMap();
        }
    }
}
