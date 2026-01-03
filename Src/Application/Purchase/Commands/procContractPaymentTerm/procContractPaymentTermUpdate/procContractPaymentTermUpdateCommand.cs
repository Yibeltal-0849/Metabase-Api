using AutoMapper;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Interfaces;
using System.Collections.Generic;
using XOKA.Domain.Entities.Purchase;

namespace Application.Purchase.Commands.procContractPaymentTerm.procContractPaymentTermUpdate.procContractPaymentTermUpdateCommand
{

    /// @author  Shimels Alem  proc_Contract_PaymentTermUpdate stored procedure.


    public class procContractPaymentTermUpdateCommand : IRequest<IList<ContractPaymentTerm_PaymentTermID>>
   {
        public System.Guid Payment_TermID { get; set; }
        public string Payment_Term { get; set; }
        public string Declaration { get; set; }
        public bool? Is_Approved { get; set; }
        public string ContractID { get; set; }
        public double? Percent { get; set; }
        public double? Total_Percent { get; set; }
        public string? Parent { get; set; }
        public string? description { get; set; }

    }



}

