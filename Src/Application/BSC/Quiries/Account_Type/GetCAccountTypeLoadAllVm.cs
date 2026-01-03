using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Bsc;

namespace XOKA.Application.BSC.Quiries.Account_Type
{
    public class GetCAccountTypeLoadAllVm : IMapFrom<Proc_C_Account_Type>
    {
        public long? Id { get; set; }
        public string Name { get; set; }
        public int Catagory { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Proc_C_Account_Type, GetCAccountTypeLoadAllVm>();
        }
    }
}
