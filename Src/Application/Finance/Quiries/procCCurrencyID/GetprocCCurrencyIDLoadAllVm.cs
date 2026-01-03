using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Quiries.procCCurrencyID
{
    public class GetprocCCurrencyIDLoadAllVm : IMapFrom<CCurrencyId>
    {
        public string CurrencyID { get; set; }
        public string Name { get; set; }
        public long Enable { get; set; }
        public double? Current_Value_To_Birr { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<CCurrencyId, GetprocCCurrencyIDLoadAllVm>();
        }
    }
}
