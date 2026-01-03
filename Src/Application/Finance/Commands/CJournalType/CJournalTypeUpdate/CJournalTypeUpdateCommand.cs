using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.CJournalType.CJournalTypeUpdate.CJournalTypeUpdateCommand
{

	/// @author  Shimels Alem  C_Journal_TypeUpdate stored procedure.


	public class CJournalTypeUpdateCommand : IRequest<IList<CJournalType_Type>>
   {
        public string Type { get; set; }
        public string Debit_Accounts { get; set; }
        public string Credit_Accounts { get; set; }
        public System.Guid? Visable_For_Form { get; set; }
        public string No_Series { get; set; }
    }
		
		
		 
}

