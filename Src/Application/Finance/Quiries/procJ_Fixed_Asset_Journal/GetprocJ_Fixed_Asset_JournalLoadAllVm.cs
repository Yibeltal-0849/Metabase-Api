using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Quiries.procJ_Fixed_Asset_Journal
{
    public class GetprocJ_Fixed_Asset_JournalLoadAllVm : IMapFrom<JFixedAssetJournal>
    {
        public System.Guid Branch_ID { get; set; }
        public System.DateTime FA_Posting_Date { get; set; }
        public string Document_Type { get; set; }
        public string Document_No { get; set; }
        public string FA_No { get; set; }
        public string Book_Code { get; set; }
        public string FA_Posting_Type { get; set; }
        public string Description { get; set; }
        public decimal? Amount { get; set; }
        public int Year { get; set; }
        public System.DateTime? Period { get; set; }
        public string GL_EnteryNO { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<JFixedAssetJournal, GetprocJ_Fixed_Asset_JournalLoadAllVm>();
        }
    }
}
