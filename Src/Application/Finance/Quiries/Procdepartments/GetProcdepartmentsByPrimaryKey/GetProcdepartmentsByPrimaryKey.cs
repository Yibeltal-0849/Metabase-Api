using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.Procdepartments.GetProcdepartmentsLoadAll;

namespace Application.Finance.Quiries.Procdepartments.GetProcdepartmentsByPrimaryKey
{
    ///     /// @author  Shimels Alem proc_departmentsLoadByPrimaryKey stored procedure.

    public class GetProcdepartmentsByPrimaryKey : IRequest<GetProcdepartmentsLoadAllListVm>
    {
        public Guid department_Code { get; set; }
    }
}
