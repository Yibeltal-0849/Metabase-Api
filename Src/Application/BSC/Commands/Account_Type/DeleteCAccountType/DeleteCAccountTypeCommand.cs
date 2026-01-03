using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Bsc;

namespace XOKA.Application.BSC.Commands.Account_Type.DeleteCAccountType
{
    public class DeleteCAccountTypeCommand : IRequest<IList<Proc_C_Account_Type_Id>>
    {
        public long? Id { get; set; }
    }
}
