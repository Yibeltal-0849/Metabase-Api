using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.ProprtyData.Quiries.procTINERCA.GetprocTINERCALoadAll;

namespace Application.ProprtyData.Quiries.procTINERCA.GetprocTINERCAByPrimaryKey
{
    /// @author  Shimels Alem proc_TIN_ERCALoadByPrimaryKey stored procedure.

    public class GetprocTINERCAByPrimaryKey : IRequest<GetprocTINERCALoadAllListVm>
    {
        public string TIN { get; set; }
    }
}
