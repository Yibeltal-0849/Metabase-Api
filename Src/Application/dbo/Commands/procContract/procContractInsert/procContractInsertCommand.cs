


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.dbo;

namespace Application.dbo.Commands.procContract.procContractInsert.procContractInsertCommand
{

    /// @author  Shimels Alem  proc_ContractInsert stored procedure.


    public class procContractInsertCommand : IRequest<IList<Contract_ContractNo>>
    {
        public string Contract_Num { get; set; }
        public string Contact_Name { get; set; }
        public System.Guid? Organization_ID { get; set; }
        public System.Guid? DIV { get; set; }
        public string Contract_Type { get; set; }
        public System.Guid? Application_Code { get; set; }
    }
		
		
		 
}
 
 