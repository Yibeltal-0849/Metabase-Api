using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XOKA.WebUI.Model
{
    public class postpurchaseandsale
    {
        public Guid OrgID { get; set; }
        public Guid Application_Code { get; set; }
        public string Application_No { get; set; }
        public Guid UserID { get; set; }
        public Guid TaskId { get; set; }
    }
}
