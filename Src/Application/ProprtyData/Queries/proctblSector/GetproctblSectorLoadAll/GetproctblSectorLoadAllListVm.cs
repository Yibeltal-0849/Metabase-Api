using System;
using System.Collections.Generic;
using System.Text;

namespace Application.ProprtyData.Queries.proctblSector.GetproctblSectorLoadAll
{
    /// @author  Shimels Alem  proc_tblSectorLoadAll stored procedure.

    public class GetproctblSectorLoadAllListVm
    {
        public long id { get; set; }
        public string Name { get; set; }
        public bool? Enable { get; set; }
        public System.DateTime? Created_Date { get; set; }
        public long? Created_By { get; set; }
        public System.DateTime? Update_Date { get; set; }
        public long? Update_by { get; set; }
        public byte[] Modified { get; set; }
        public IList<GetproctblSectorLoadAllVm> proctblSectors { get; set; }
    }
}
