using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Application.HRA.Quiries.CEmployee_Pay_Info;
using XOKA.Domain.Entities.Finance;

namespace XOKA.Application.HRA.Commands.CEmployee_Pay_Info.UpdateCEmployeePayInfo
{
    /// @author  Shimels Alem  UpdateCEmployeePayInfo stored procedure.
    
    public class UpdateCEmployeePayInfoCommand : GetCEmployeePayInfoLoadAllVm, IRequest<IList<CEmployeePayInfo_id>>
    {
    }
}
