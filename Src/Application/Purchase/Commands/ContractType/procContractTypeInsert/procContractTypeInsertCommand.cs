using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Purchase;

namespace Application.Purchase.Commands.ContractType.procContractTypeInsert
{
    public class procContractTypeInsertCommand : IRequest<IList<ReciveContractType_Code>>
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
