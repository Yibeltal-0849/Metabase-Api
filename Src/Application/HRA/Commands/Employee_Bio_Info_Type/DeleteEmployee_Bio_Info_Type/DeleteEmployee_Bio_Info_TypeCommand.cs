using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.HRA;

namespace XOKA.Application.HRA.Commands.Employee_Bio_Info_Type.DeleteEmployee_Bio_Info_Type
{
    /// @author  Shimels Alem  proc_Employee_Bio_Info_TypeDelete stored procedure.

    public class DeleteEmployee_Bio_Info_TypeCommand : IRequest<IList<EmployeeBioInfoType_Bio_Type_ID>>
    {
        public string Bio_Type_ID { get; set; }
    }
}
