


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.cCustomerBalance.cCustomerBalanceInsert.cCustomerBalanceInsertCommand
{

    /// @author  Shimels Alem  c_Customer_BalanceInsert stored procedure.


    public class cCustomerBalanceInsertCommand : IRequest<IList<CCustomerBalance_Id>>
    {
        public long? Id { get; set; }
        public string Org_id { get; set; }
        public string Customer_ID { get; set; }
        public System.DateTime Date { get; set; }
        public string Invoice_Number { get; set; }
        public string Purchase_Order_Number { get; set; }
        public decimal? Amount { get; set; }
        public string A_RAccount { get; set; }
    }
		
		
		 
	}
 
 