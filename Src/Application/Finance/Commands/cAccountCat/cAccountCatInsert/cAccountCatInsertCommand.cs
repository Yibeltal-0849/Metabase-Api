


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Bsc;

namespace Application.Finance.Commands.cAccountCat.cAccountCatInsert.cAccountCatInsertCommand
{

    /// @author  Shimels Alem  c_Account_CatInsert stored procedure.


    public class cAccountCatInsertCommand : IRequest<IList<Proc_C_Account_Cat_Code>>
    {
        public int Code { get; set; }
        public string Name { get; set; }
    }
		
		
		 
	}
 
 