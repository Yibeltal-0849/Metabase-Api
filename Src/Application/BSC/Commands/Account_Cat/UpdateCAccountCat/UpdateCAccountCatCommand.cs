using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Application.BSC.Quiries.Account_Cat;
using XOKA.Domain.Entities.Bsc;

namespace XOKA.Application.BSC.Commands.Account_Cat.UpdateCAccountCat
{
    public class UpdateCAccountCatCommand : GetCAccountCatLoadAllVM, IRequest<IList<Proc_C_Account_Cat_Code>>
    {
    }
}
