using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.procPaySlip.GetprocPaySlipLoadAll;

namespace Application.Finance.Quiries.procPaySlip.GetprocPaySlipByPrimaryKeyPayrole_Trans_Id
{
    /// @author  Shimels Alem proc_Pay_SlipLoadByPrimaryKey stored procedure.

    public class GetprocPaySlipByPrimaryKeyPayrole_Trans_Id : IRequest<GetprocPaySlipLoadAllListVm>
    {
        public System.Guid? Payrole_Trans_Id { get; set; }
    }
}
