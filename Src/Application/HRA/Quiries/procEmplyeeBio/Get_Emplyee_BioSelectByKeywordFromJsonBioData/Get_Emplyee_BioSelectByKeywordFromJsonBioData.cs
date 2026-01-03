using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.HRA.Quiries.procEmplyeeBio.GetprocEmplyeeBioLoadAll;

namespace Application.HRA.Quiries.procEmplyeeBio.Get_Emplyee_BioSelectByKeywordFromJsonBioData
{
    /// @author  Shimels Alem proc_Emplyee_BioLoadByPrimaryKey stored procedure.

    public class Get_Emplyee_BioSelectByKeywordFromJsonBioData : IRequest<GetprocEmplyeeBioLoadAllListVm>
    {
        public string keyword { get; set; }
    }
}
