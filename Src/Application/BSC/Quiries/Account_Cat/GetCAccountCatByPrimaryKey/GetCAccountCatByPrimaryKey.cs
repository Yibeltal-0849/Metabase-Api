using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Application.BSC.Quiries.Account_Cat.GetCAccountCatLoadAll;

namespace XOKA.Application.BSC.Quiries.Account_Cat.GetCAccountCatByPrimaryKey
{
    public class GetCAccountCatByPrimaryKey : IRequest<GetCAccountCatLoadAllListVm>
    {
        public int Code { get; set; }
    }
}
