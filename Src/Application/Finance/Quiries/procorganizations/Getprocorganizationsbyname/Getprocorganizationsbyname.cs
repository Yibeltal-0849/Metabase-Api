using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.procorganizations.GetprocorganizationsLoadAll;

namespace Application.Finance.Quiries.procorganizations.Getprocorganizationsbyname
{
    ///     /// @author  Shimels Alem GetprocorganizationsByPrimaryKey stored procedure.

    public class Getprocorganizationsbyname : IRequest<GetprocorganizationsLoadAllListVm>
    {
        public string name_En { get; set; }
    }
}
