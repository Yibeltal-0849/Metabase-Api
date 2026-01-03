using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Quiries.procCJournalType
{
    public class GetprocCJournalTypeLoadAllVm : IMapFrom<CJournalType>
    {

        public string Type { get; set; }
        public string Debit_Accounts { get; set; }
        public string Credit_Accounts { get; set; }
        public System.Guid? Visable_For_Form { get; set; }
        public string No_Series { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<CJournalType, GetprocCJournalTypeLoadAllVm>();
        }
    }
}
