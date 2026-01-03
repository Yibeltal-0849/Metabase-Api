using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.ProcGoalsInnitiativeMapping.GetProcGoalsInnitiativeMappingLoadAll;

namespace Application.Finance.Quiries.ProcGoalsInnitiativeMapping.GetProcGoalsInnitiativeMappingByPrimaryKey
{
    /// @author  Shimels Alem proc_Goals_Innitiative_MappingLoadByPrimaryKey stored procedure.

    public class GetProcGoalsInnitiativeMappingByPrimaryKey : IRequest<GetProcGoalsInnitiativeMappingLoadAllListVm>
    {
       public Guid InnitiativeMapping_ID { get; set; }
    }
}
