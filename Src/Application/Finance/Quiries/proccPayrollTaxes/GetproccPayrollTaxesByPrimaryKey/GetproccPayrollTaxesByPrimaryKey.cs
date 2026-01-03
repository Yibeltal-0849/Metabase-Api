using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.proccPayrollTaxes.GetproccPayrollTaxesLoadAll;

namespace Application.Finance.Quiries.proccPayrollTaxes.GetproccPayrollTaxesByPrimaryKey
{
    /// @author  Shimels Alem proc_c_PayrollTaxesLoadByPrimaryKey stored procedure.

    public class GetproccPayrollTaxesByPrimaryKey : IRequest<GetproccPayrollTaxesLoadAllListVm>
    {
        public long Id { get; set; }
    }
}
