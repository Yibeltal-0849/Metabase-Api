using AutoMapper;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Interfaces;
using System.Collections.Generic;
using XOKA.Domain.Entities.Purchase;

namespace Application.Purchase.Commands.ContractType.procContractTypeUpdate
{
    public class procContractTypeUpdateCommand : IRequest<IList<ReciveContractType_Code>>
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Numbering { get; set; }
        public string Last_Numbering_used { get; set; }
        public System.DateTime Last_Numbering_Date { get; set; }
        public bool IsActive { get; set; }
        public System.Guid Organization_ID { get; set; }
    }
}
