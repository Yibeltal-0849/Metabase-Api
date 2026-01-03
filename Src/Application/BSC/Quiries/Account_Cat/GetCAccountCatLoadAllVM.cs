using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Bsc;

namespace XOKA.Application.BSC.Quiries.Account_Cat
{
    public class GetCAccountCatLoadAllVM : IMapFrom<Proc_C_Account_Cat>
    {
        public int? Code { get; set; }
        public string Name { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Proc_C_Account_Cat, GetCAccountCatLoadAllVM>();
        }
    }
}

