using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Bsc;

namespace XOKA.Application.BSC.Commands.Account_Cat.DeleteCAccountCat
{
    public class DeleteCAccountCatCommand : IRequest<IList<Proc_C_Account_Cat_Code>>
    {
        public int Code { get; set; }
    }
}
