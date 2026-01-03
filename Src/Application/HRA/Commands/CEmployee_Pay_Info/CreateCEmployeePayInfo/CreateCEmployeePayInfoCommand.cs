using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Application.HRA.Quiries.CEmployee_Pay_Info;
using XOKA.Domain.Entities.Finance;

namespace XOKA.Application.HRA.Commands.CEmployee_Pay_Info.CreateCEmployeePayInfo
{
    /// @author  Shimels Alem  CreateCEmployeePayInfo stored procedure.
    
    public class CreateCEmployeePayInfoCommand : GetCEmployeePayInfoLoadAllVm, IRequest<IList<CEmployeePayInfo_id>>
    {        
    }
}
