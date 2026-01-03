using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.procPPurchaseInvoice.GetprocPPurchaseInvoiceLoadAll;

namespace Application.Finance.Quiries.procPPurchaseInvoice.GetprocPPurchaseInvoiceByPrimaryKey
{
    /// @author  Shimels Alem [proc_P_Purchase_InvoiceLoadByPrimaryKey] stored procedure.

    public class GetprocPPurchaseInvoiceByPrimaryKey : IRequest<GetprocPPurchaseInvoiceLoadAllListVm>
    {
        public System.Guid Purchase_Line { get; set; }
    }
}
