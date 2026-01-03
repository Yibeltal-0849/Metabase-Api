using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XOKA.WebUI.Model
{
    public class provisionUpgrade
    {


        public System.Guid? Department_code { get; set; }
        public string New_Provision { get; set; }
        public string Old_Provision { get; set; }
        public string Job_Position { get; set; }
        public string Grade { get; set; }

    }
}
