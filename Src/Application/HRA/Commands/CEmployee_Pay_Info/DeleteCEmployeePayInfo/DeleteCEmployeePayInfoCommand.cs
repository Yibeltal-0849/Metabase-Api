using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Finance;

namespace XOKA.Application.HRA.Commands.CEmployee_Pay_Info.DeleteCEmployeePayInfo
{
    /// @author  Shimels Alem  DeleteCEmployeePayInfo stored procedure.
    
    public class DeleteCEmployeePayInfoCommand : IRequest<IList<CEmployeePayInfo_id>>
    {
        public long Id { get; set; }
    }
}
