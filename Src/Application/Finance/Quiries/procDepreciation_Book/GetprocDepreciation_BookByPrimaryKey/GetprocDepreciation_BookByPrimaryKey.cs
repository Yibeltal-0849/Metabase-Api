using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.procDepreciation_Book.GetprocDepreciation_BookLoadAll;

namespace Application.Finance.Quiries.procDepreciation_Book.GetprocDepreciation_BookByPrimaryKey
{
    /// @author  Shimels Alem proc_c_CA_Beginning_BalanceLoadByPrimaryKey stored procedure.

    public class GetprocDepreciation_BookByPrimaryKey : IRequest<GetprocDepreciation_BookLoadAllListVm>
    {
        public int Year { get; set; }
        public string Fixed_Assets_No { get; set; }
        //public bool Is_IFRS { get; set; }
    }
}
