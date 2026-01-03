using System;
using System.Collections.Generic;
using System.Text;

namespace Application.ProprtyData.Queries.proctblImport.GetproctblImportLoadAll
{
    /// @author  Shimels Alem  proc_tblImportLoadAll stored procedure.

    public class GetproctblImportLoadAllListVm
    {
        public IList<GetproctblImportLoadAllVm> proctblImports { get; set; }
    }
}
