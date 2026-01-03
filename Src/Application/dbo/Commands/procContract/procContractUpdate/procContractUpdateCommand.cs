using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.dbo;
using XOKA.Domain.Interfaces;

namespace Application.dbo.Commands.procContract.procContractUpdate.procContractUpdateCommand
{

    /// @author  Shimels Alem  proc_ContractUpdate stored procedure.


    public class procContractUpdateCommand : IRequest<IList<Contract_ContractNo>>
   {
        public string Contract_No { get; set; }
        public string Contact_Name { get; set; }
        public System.Guid? Organization_ID { get; set; }
        public System.Guid? DIV { get; set; }
        public string Contract_Type { get; set; }
        public System.Guid? Application_Code { get; set; }
    }
		
		
		 
}

