


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.CCurrencyID.CCurrencyIDInsert.CCurrencyIDInsertCommand
{

    /// @author  Shimels Alem  C_Currency_IDInsert stored procedure.


    public class CCurrencyIDInsertCommand : IRequest<IList<CCurrencyId_CurrencyID>>
    {
        public string CurrencyID { get; set; }
        public string Name { get; set; }
        public long Enable { get; set; }
        public double? Current_Value_To_Birr { get; set; }
    }
		
		
		 
	}
 
 