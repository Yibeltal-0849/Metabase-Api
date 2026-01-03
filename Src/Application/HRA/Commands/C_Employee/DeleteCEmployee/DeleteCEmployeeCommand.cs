using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.HRA;

namespace XOKA.Application.HRA.Commands.CEmployee.DeleteCEmployee
{
    /// @author  Shimels Alem  DeleteCEmployee stored procedure.
    
    public class DeleteCEmployeeCommand : IRequest<IList<CEmployee_Employee_Id>>
    {
        public string Employee_Id { get; set; }
    }
}
