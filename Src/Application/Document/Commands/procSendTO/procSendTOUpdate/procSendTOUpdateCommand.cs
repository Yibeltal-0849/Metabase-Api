using AutoMapper;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Interfaces;
using System.Collections.Generic;
using XOKA.Domain.Entities.Document;

namespace Application.Document.Commands.procSendTO.procSendTOUpdate.procSendTOUpdateCommand
{

    /// @author  Shimels Alem  proc_Send_TOUpdate stored procedure.


    public class procSendTOUpdateCommand : IRequest<IList<SendTO_EmailID>>
   {
        public System.Guid Email_ID { get; set; }
        public System.Guid? Letter_ID { get; set; }
        public System.Guid? Org_ID { get; set; }
        public System.Guid? Department_ID { get; set; }
        public System.Guid? Stracture_Role_ID { get; set; }
        public bool? Cc { get; set; }
    }
		
		
		 
}

