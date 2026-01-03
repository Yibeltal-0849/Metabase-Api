using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace XOKA.Application.HRA.Quiries.BankDetail
{
    public class GetBankDetailLoadAllQuery : IRequest<GetBankDetailLoadAllListVm>
    {
        public string Employee_Id { get; internal set; }
    }
}
