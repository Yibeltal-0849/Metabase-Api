using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.cCustomerBalance.cCustomerBalanceUpdate.cCustomerBalanceUpdateCommand
{

    /// @author  Shimels Alem  c_Customer_BalanceUpdate stored procedure.


    public class cCustomerBalanceUpdateCommand : IRequest<IList<CCustomerBalance_Id>>
   {
        public long Id { get; set; }
        public string Org_id { get; set; }
        public string Customer_ID { get; set; }
        public System.DateTime Date { get; set; }
        public string Invoice_Number { get; set; }
        public string Purchase_Order_Number { get; set; }
        public decimal? Amount { get; set; }
        public string A_RAccount { get; set; }
    }
		
		
		 
	}

