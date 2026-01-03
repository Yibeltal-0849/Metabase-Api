using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Quiries.procJJOBJournal
{
    public class GetprocJJOBJournalLoadAllVm : IMapFrom<JJobJournal>
    {

        public System.Guid Branch_ID { get; set; }
        public string Line_Type { get; set; }
        public System.DateTime Posting_Date { get; set; }
        public string Document_No { get; set; }
        public string Job_No { get; set; }
        public string Job_Task_No { get; set; }
        public string Type { get; set; }
        public int? No { get; set; }
        public string Description { get; set; }
        public string Location_Code { get; set; }
        public System.Guid JOB_Work_Type_Code { get; set; }
        public string Unit_of_Measure_Code { get; set; }
        public int Quantity { get; set; }
        public decimal Unit_Cost { get; set; }
        public string Unit_Cost_LCY { get; set; }
        public decimal Total_Cost { get; set; }
        public decimal Total_Cost_LCY { get; set; }
        public decimal Unit_Price { get; set; }
        public decimal? Line_Amount { get; set; }
        public decimal? Line_Discount_Amount { get; set; }
        public double? Line_Discount_Per { get; set; }
        public bool? Applies_to_Entry { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<JJobJournal, GetprocJJOBJournalLoadAllVm>();
        }
    }
}
