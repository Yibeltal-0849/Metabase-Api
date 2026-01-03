using System;
using System.Collections.Generic;
using System.Text;

namespace Application.ProprtyData.Queries.proctblDemand.GetproctblDemandLoadAll
{
    /// @author  Shimels Alem  proc_tblDemandLoadAll stored procedure.

    public class GetproctblDemandLoadAllListVm
    {
        public IList<GetproctblDemandLoadAllVm> proctblDemands { get; set; }
    }
}
