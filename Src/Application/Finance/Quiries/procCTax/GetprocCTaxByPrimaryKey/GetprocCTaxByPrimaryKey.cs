using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.procCTax.GetprocCTaxLoadAll;

namespace Application.Finance.Quiries.procCTax.GetprocCTaxByPrimaryKey
{
    /// @author  Shimels Alem proc_C_TaxLoadByPrimaryKey stored procedure.

    public class GetprocCTaxByPrimaryKey : IRequest<GetprocCTaxLoadAllListVm>
    {
        public string Code { get; set; }
    }
}
