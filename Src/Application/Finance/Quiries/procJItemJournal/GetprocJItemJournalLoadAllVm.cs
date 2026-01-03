using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Quiries.procJItemJournal
{
    public class GetprocJItemJournalLoadAllVm : IMapFrom<JItemJournal>
    {

        public System.Guid Branch_ID { get; set; }
        public System.DateTime Posting_Date { get; set; }
        public string Entry_Type { get; set; }
        public string Document_No { get; set; }
        public string Item_No { get; set; }
        public string Description { get; set; }
        public string Location_Code { get; set; }
        public int? Quantity { get; set; }
        public string Unit_of_Measure_Code { get; set; }
        public decimal? Unit_Amount { get; set; }
        public decimal? Amount { get; set; }
        public decimal? Discount_Amount { get; set; }
        public decimal? Unit_Cost { get; set; }
        public bool? Applies_to_Entry { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<JItemJournal, GetprocJItemJournalLoadAllVm>();
        }
    }
}
