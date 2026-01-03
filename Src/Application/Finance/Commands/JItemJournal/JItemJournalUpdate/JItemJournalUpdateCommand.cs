using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.JItemJournalUpdate.JItemJournalUpdateCommand
{

    /// @author  Henok Solomon  J_Item_JournalUpdate stored procedure.

    #region J_Bank_Acc_ReconciliationUpdate  

    /// J_Item_JournalUpdate stored procedure.

    public class JItemJournalUpdateCommand : IRequest<IList<JItemJournal_Branch_ID>>
   {
        public System.Guid Branch_ID { get; set; }
        public System.DateTime Posting_Date { get; set; }
        public string Entry_Type { get; set; }
        public string Document_No { get; set; }
        public string Item_No { get; set; }
        public string Description { get; set; }
        public string Location_Code { get; set; }
        public int? Quantity { get; set; }
        public string Unit_of_Measure_Code { get; set; }
        public decimal? Unit_Amount { get; set; }
        public decimal? Amount { get; set; }
        public decimal? Discount_Amount { get; set; }
        public decimal? Unit_Cost { get; set; }
        public bool? Applies_to_Entry { get; set; }
    }
		
       #endregion
		
		 
	}

