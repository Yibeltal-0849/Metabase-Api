using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Application.BSC.Quiries.Account_Type.GetCAccountTypeLoadAll;

namespace XOKA.Application.BSC.Quiries.Account_Type.GetCAccountTypeByPrimaryKey
{
    public class GetCAccountTypeByPrimaryKey : IRequest<GetCAccountTypeLoadAllListVm>
    {
        public long Id { get; set; }
    }
}
