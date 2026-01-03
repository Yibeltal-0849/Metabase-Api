using System;
using System.Collections.Generic;
using System.Text;
using MediatR;


namespace XOKA.Application.HRA.Quiries.BankDetail
{
   public class GetBankDetailByEmployeeID : IRequest<GetBankDetailLoadAllListVm>
    {
        public string Employee_Id { get; set; }
    }
}
