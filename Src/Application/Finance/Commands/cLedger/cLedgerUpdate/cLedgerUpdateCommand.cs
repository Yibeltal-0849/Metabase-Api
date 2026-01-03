using AutoMapper;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.cLedger.cLedgerUpdate.cLedgerUpdateCommand
{ 
	 
	/// @author  Shimels Alem  XXXX stored procedure.
	 
    
       public class cLedgerUpdateCommand : IRequest
   {
        public System.DateTime Period_ID { get; set; }
        public string Account_ID { get; set; }
        public string Narration { get; set; }
        public double? Amount { get; set; }
    }
		
		
		 
}

