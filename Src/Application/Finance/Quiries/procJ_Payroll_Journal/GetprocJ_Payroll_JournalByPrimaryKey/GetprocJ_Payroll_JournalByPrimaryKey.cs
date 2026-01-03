using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.procJ_Payroll_Journal.GetprocJ_Payroll_JournalLoadAll;

namespace Application.Finance.Quiries.procJ_Payroll_Journal.GetprocJ_Payroll_JournalByPrimaryKey
{
    /// @author  Shimels Alem proc_c_CA_Beginning_BalanceLoadByPrimaryKey stored procedure.

    public class GetprocJ_Payroll_JournalByPrimaryKey : IRequest<GetprocJ_Payroll_JournalLoadAllListVm>
    {
        public System.Guid Trans_ID { get; set; }
        public System.DateTime Posting_Date { get; set; }
        public string Emplyee_ID { get; set; }
       
    }
}
