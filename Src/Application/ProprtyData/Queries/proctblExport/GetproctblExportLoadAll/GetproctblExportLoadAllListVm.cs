using System;
using System.Collections.Generic;
using System.Text;

namespace Application.ProprtyData.Queries.proctblExport.GetproctblExportLoadAll
{
    /// @author  Shimels Alem  proc_tblExportLoadAll stored procedure.

    public class GetproctblExportLoadAllListVm
    {
        public IList<GetproctblExportLoadAllVm> proctblExports { get; set; }
    }
}
