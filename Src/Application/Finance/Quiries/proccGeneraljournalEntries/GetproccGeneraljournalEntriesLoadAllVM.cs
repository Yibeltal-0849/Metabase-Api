 

using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Interfaces;
using XOKA.Domain.Entities.Finance;
using Application.Common.Mappings;

using Application.Finance.Quiries.proccGeneraljournalEntries.GetproccGeneraljournalEntriesLoadAll;

namespace Application.Finance.Quiries.proccGeneraljournalEntries
{ 
	 
	#region proccGeneraljournalEntriesLoadAll  
    
      public class GetproccGeneraljournalEntriesLoadAllVM : IMapFrom<GetproccGeneraljournalEntriesLoadAllListVM>
    {
   
        public System.Guid Brnach_ID { get; set; }
        public System.DateTime DateDoc { get; set; }
        public string Document_Type { get; set; }
        public string Account_No { get; set; }
        public string Journal_Type { get; set; }
        public string Document_No { get; set; }
        public string Account_Type { get; set; }
        public string Description { get; set; }
        public string C_Currency_ID { get; set; }
        public decimal? Amount { get; set; }
        public double? ControlAmt { get; set; }
        public string Bal_Document_Type { get; set; }
        public string Bal_Account_No { get; set; }
        public string Bal_Journal_Type { get; set; }
        public string Bal_Account_Type { get; set; }
        public decimal? Bal_Amount { get; set; }
        public decimal? Bal_ControlAmt { get; set; }
        public string Bal_Document_No { get; set; }
        public string Remark { get; set; }
        public bool? Processing { get; set; }
        public bool? Processed { get; set; }
        public bool? Posted { get; set; }
        public System.DateTime? C_Period_ID { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap< CGeneralJournalEntries, GetproccGeneraljournalEntriesLoadAllVM>();
        }
    }
    #endregion
	
}

