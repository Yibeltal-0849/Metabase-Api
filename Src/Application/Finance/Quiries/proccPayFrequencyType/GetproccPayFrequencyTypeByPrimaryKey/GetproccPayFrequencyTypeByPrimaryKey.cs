using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.proccPayFrequencyType.GetproccPayFrequencyTypeLoadAll;

namespace Application.Finance.Quiries.proccPayFrequencyType.GetproccPayFrequencyTypeByPrimaryKey
{
    /// @author  Shimels Alem proc_c_PayFrequencyTypeLoadByPrimaryKey stored procedure.

    public class GetproccPayFrequencyTypeByPrimaryKey : IRequest<GetproccPayFrequencyTypeLoadAllListVm>
    {
        public string Name { get; set; }
    }
}
