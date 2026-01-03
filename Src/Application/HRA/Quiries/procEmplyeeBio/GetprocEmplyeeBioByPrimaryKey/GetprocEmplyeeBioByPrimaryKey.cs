using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.HRA.Quiries.procEmplyeeBio.GetprocEmplyeeBioLoadAll;

namespace Application.HRA.Quiries.procEmplyeeBio.GetprocEmplyeeBioByPrimaryKey
{
    /// @author  Shimels Alem proc_Emplyee_BioLoadByPrimaryKey stored procedure.

    public class GetprocEmplyeeBioByPrimaryKey : IRequest<GetprocEmplyeeBioLoadAllListVm>
    {
        public System.Guid Emp_Bio { get; set; }
    }
}
