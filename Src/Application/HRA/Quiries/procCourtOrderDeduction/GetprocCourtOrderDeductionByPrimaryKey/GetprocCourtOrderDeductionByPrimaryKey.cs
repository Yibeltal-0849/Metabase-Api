using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.HRA.Quiries.procCourtOrderDeduction.GetprocCourtOrderDeductionLoadAll;

namespace Application.HRA.Quiries.procCourtOrderDeduction.GetprocCourtOrderDeductionByPrimaryKey
{
    /// @author  Shimels Alem proc_Court_Order_DeductionLoadByPrimaryKey stored procedure.

    public class GetprocCourtOrderDeductionByPrimaryKey : IRequest<GetprocCourtOrderDeductionLoadAllListVm>
    {
        public System.Guid Court_Order_ID { get; set; }
    }
}
