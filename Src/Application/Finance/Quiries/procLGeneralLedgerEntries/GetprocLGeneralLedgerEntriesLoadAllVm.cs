using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Quiries.procLGeneralLedgerEntries
{
    public class GetprocLGeneralLedgerEntriesLoadAllVm : IMapFrom<LGeneralLedgerEntries>
    {
        public System.DateTime Posting_Date { get; set; }
        public System.Guid Branch_ID { get; set; }
        public System.DateTime Period { get; set; }
        public string Document_Type { get; set; }
        public string Document_No { get; set; }
        public string G_L_Account_No { get; set; }
        public string Description { get; set; }
        public string Gen_Posting_Type { get; set; }
        public string Gen_Bus_Posting_Group { get; set; }
        public string Gen_Prod_Posting_Group { get; set; }
        public double Amount { get; set; }
        public string Bal_Account_Type { get; set; }
        public string Bal_Account_No { get; set; }
        public Nullable<long> Entry_Number { get; set; }
        public string Side { get; set; }
        public Nullable<double> Balance { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<LGeneralLedgerEntries, GetprocLGeneralLedgerEntriesLoadAllVm>();
        }
    }
}
