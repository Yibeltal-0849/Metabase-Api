using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.procSSalesInvoice.GetprocSSalesInvoiceLoadAll;

namespace Application.Finance.Quiries.procSSalesInvoice.GetprocSSalesInvoiceByPrimaryKey
{
    /// @author  Shimels Alem proc_S_Sales_InvoiceLoadByPrimaryKey stored procedure.

    public class GetprocSSalesInvoiceByPrimaryKey : IRequest<GetprocSSalesInvoiceLoadAllListVm>
    {
        public string Sales_Invoice_Line { get; set; }
    }
}
