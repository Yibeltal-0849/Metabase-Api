using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Bsc;

namespace Application.BSC.Quiries.procCCurrencyID
{
    public class GetprocCCurrencyIDLoadAllVm : IMapFrom<Proc_C_Currency_ID>
    {
        public string CurrencyID { get; set; }
        public string Name { get; set; }
        public long? Enable { get; set; }
        public double? Current_Value_To_Birr { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<Proc_C_Currency_ID, GetprocCCurrencyIDLoadAllVm>();
        }
    }
}
