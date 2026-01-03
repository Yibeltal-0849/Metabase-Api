using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Application.BSC.Quiries.Account_Type;
using XOKA.Domain.Entities.Bsc;

namespace XOKA.Application.BSC.Commands.Account_Type.UpdateCAccountType
{
    public class UpdateCAccountTypeCommand : GetCAccountTypeLoadAllVm, IRequest<IList<Proc_C_Account_Type_Id>>
    {
    }
}
