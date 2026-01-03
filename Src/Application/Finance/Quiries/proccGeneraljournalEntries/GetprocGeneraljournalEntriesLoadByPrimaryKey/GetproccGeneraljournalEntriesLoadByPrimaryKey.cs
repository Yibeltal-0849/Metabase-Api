

using MediatR; 
using Application.Finance.Quiries.proccGeneraljournalEntries.GetproccGeneraljournalEntriesLoadAll; 

namespace Application.Finance.Quiries.proccGeneraljournalEntries.GetprocGeneraljournalEntriesLoadByPrimaryKey
{ 
	 
	#region proccGeneraljournalEntriesLoadByPrimaryKey  
    	
 public class GetproccGeneraljournalEntriesLoadByPrimaryKey  : IRequest<GetproccGeneraljournalEntriesLoadAllListVM>
    {

		public string Account_No { get; set; }
		public System.Guid brnach_ID { get; set; }
		public System.DateTime dateDoc { get; set; }


	}
   
        #endregion
		
	  
	
		
	
    
}

