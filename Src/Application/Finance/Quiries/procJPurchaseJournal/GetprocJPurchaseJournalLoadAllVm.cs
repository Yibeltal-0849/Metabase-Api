using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Quiries.procJPurchaseJournal
{
    public class GetprocJPurchaseJournalLoadAllVm : IMapFrom<JPurchaseJournal>
    {

        public System.Guid Org_ID { get; set; }
        public System.Guid Brnach_ID { get; set; }
        public System.DateTime Posting_Date { get; set; }
        public string Document_Type { get; set; }
        public string Document_No { get; set; }
        public string Account_Type { get; set; }
        public string Account_No { get; set; }
        public string Description { get; set; }
        public string Gen_Posting_Type { get; set; }
        public string Gen_Bus_Posting_Group { get; set; }
        public string Gen_Prod_Posting_Group { get; set; }
        public decimal Amount { get; set; }
        public string Bal_Account_Type { get; set; }
        public string Bal_Account_No { get; set; }
        public string Bal_Gen_Posting_Type { get; set; }
        public string Bal_Gen_Bus_Posting_Group { get; set; }
        public string Bal_Gen_Prod_Posting_Group { get; set; }
        public decimal Bal_Amount { get; set; }
        public string Applies_to_Doc_Type { get; set; }
        public string Applies_to_Doc_No { get; set; }
        public bool? On_Hold { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<JPurchaseJournal, GetprocJPurchaseJournalLoadAllVm>();
        }
    }
}
