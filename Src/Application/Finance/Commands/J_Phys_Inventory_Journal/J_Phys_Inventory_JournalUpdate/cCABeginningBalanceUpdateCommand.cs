using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.J_Phys_Inventory_Journal.J_Phys_Inventory_JournalUpdate.J_Phys_Inventory_JournalUpdateCommand
{

	/// @author  Shimels Alem  c_CA_Beginning_BalanceUpdate stored procedure.


	public class J_Phys_Inventory_JournalUpdateCommand : IRequest<IList<J_Phys_Inventory_Journal_Posting_Date>>
    {
        public System.DateTime Posting_Date { get; set; }
        public string Entry_Type { get; set; }
        public string Document_No { get; set; }
        public string Item_No { get; set; }
        public string Description { get; set; }
        public string Location_Code { get; set; }
        public Nullable<double> Qty_Calculated { get; set; }
        public Nullable<double> Qty_Phys_Inventory { get; set; }
        public Nullable<int> Quantity { get; set; }
        public Nullable<double> Amount_Birr { get; set; }
        public Nullable<double> Unit_Cost_Birr { get; set; }
        public Nullable<long> Last_Item_Ledger_Entry_No { get; set; }
        public long Entry_No { get; set; }
        public Guid Brnach_ID { get; set; }
    }
		
		
		 
	}

