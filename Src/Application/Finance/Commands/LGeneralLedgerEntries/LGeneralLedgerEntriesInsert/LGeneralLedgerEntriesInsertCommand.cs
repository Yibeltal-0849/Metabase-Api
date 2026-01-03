


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Bsc;

namespace Application.Finance.Commands.LGeneralLedgerEntries.LGeneralLedgerEntriesInsert.LGeneralLedgerEntriesInsertCommand
{

    /// @author  Shimels Alem  LGeneralLedgerEntriesInsert stored procedure.


    public class LGeneralLedgerEntriesInsertCommand : IRequest<IList<Proc_LGeneralLedgerEntries_Code>>
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
    }
		
		
		 
	}
 
 