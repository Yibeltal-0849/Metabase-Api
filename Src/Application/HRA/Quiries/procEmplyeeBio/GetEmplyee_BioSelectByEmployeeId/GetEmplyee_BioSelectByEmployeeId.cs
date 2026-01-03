using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.HRA.Quiries.procEmplyeeBio.GetprocEmplyeeBioLoadAll;

namespace Application.HRA.Quiries.procEmplyeeBio.GetEmplyee_BioSelectByEmployeeId
{
    /// @author  Shimels Alem proc_Emplyee_BioLoadByPrimaryKey stored procedure.

    public class GetEmplyee_BioSelectByEmployeeId : IRequest<GetprocEmplyeeBioLoadAllListVm>
    {
        public string employeeId { get; set; }
        public string bioType { get; set; }
    }
}
