 
using AutoMapper;
using HealthEquity.Data.Entity;
using HealthEquity.Models;
 

namespace HealthEquity.Data.Mapper
{
    public class MemberProfile : Profile
    {
        public MemberProfile()
        {
            this.CreateMap<Member, MemberModel>()
                .ReverseMap();     
        }
    }
}
