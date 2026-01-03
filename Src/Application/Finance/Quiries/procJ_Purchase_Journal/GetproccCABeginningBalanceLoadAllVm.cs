using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Quiries.proccJ_Purchase_Journal
{
    public class GetproccJ_Purchase_JournalLoadAllVm : IMapFrom<JPurchaseJournal>
    {
        public System.DateTime Period { get; set; }
        public string Account_id { get; set; }
        public string Account_Decscrption { get; set; }
        public decimal? Assets_Expense { get; set; }
        public decimal? Liability_Equity_incom { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<JPurchaseJournal, GetproccJ_Purchase_JournalLoadAllVm>();
        }
    }
}
