using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using AutoMapper;
using HealthEquity.Models;
using static AutoMapper.Internal.ExpressionFactory;

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
