using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Quiries.procJInsuranceJournal
{
    public class GetprocJInsuranceJournalLoadAllVm : IMapFrom<JInsuranceJournal>
    {

        public System.Guid Branch_ID { get; set; }
        public string Posting_Date { get; set; }
        public string Document_Type { get; set; }
        public string Document_No { get; set; }
        public string Insurance_No { get; set; }
        public string Fixed_Asset_No { get; set; }
        public string Description { get; set; }
        public decimal? Amount { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<JInsuranceJournal, GetprocJInsuranceJournalLoadAllVm>();
        }
    }
}
