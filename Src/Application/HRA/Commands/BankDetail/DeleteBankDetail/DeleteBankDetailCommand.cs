using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.HRA;

namespace XOKA.Application.HRA.Commands.BankDetail.DeleteBankDetail
{
    /// @author  Shimels Alem  DeleteBankDetail stored procedure.
    
    public class DeleteBankDetailCommand : IRequest<IList<BankDetail_id>>
    {
        public Guid bankid { get; set; }
    }
}
