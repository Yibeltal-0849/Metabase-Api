using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Quiries.procJGeneraljournal
{
    public class GetprocJGeneraljournalLoadAllVm : IMapFrom<JGeneralJournal>
    {

        public System.Guid Brnach_ID { get; set; }
        public System.DateTime Posting_Date { get; set; }
        public string Document_Type { get; set; }
        public string Document_NO { get; set; }
        public string Account_Type { get; set; }
        public string Account_Id { get; set; }
        public string Description { get; set; }
        public string Gen_Posting_Type { get; set; }
        public string Gen_Bus_Posting_Group { get; set; }
        public string Gen_Prod_Posting_Group { get; set; }
        public decimal Amount { get; set; }
        public string Bal_Document_Type { get; set; }
        public string Bal_Document_No { get; set; }
        public string Bal_Account_Type { get; set; }
        public string Bal_Account_No { get; set; }
        public string Bal_Gen_Posting_Type { get; set; }
        public string Bal_Gen_Bus_Posting_Group { get; set; }
        public string Bal_Gen_Prod_Posting_Group { get; set; }
        public decimal Bal_Amount { get; set; }
        public string Remark { get; set; }
        public bool? Processed { get; set; }
        public bool? Posted { get; set; }
        public System.DateTime C_Period_ID { get; set; }
        public string Log { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<JGeneralJournal, GetprocJGeneraljournalLoadAllVm>();
        }
    }
}
