using AutoMapper;
using CashManagement.Domain.Model;
using CashManagement.Entity;

namespace CashManagement.Domain.Infrastructure
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<CcyModel, ccy_base>();
            CreateMap<ccy_base, CcyModel>();
            CreateMap<UserModel, User>()
                .ForMember(dest => dest.Password, opt => opt.Ignore());
            CreateMap<User, UserModel>();
            CreateMap<RoleModel, Role>();
            CreateMap<Role, RoleModel>();

            CreateMap<UserModel, LoginFormModel>()
                .ForMember(dest => dest.Password, opt => opt.MapFrom(m => m.ViewPassword));
            CreateMap<LoginFormModel, UserModel>()
                .ForMember(dest => dest.ViewPassword, opt => opt.MapFrom(m => m.Password));
        }
    }
}
