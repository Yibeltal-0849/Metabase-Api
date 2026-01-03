using System;
using System.Collections.Generic;
using System.Text;

namespace XOKA.Domain.Entities.Bsc
{
    public class Proc_Company_Strategy
    {
		public string Strategy_NO{ get; set; }
		public Guid Organization_code { get; set; }
		public string Title{ get; set; }
		public string Version{ get; set; }
		public string Vision{ get; set; }
		public string Mission{ get; set; }
		public string Values{ get; set; }
		public byte[] File { get; set; }
		public int? Start_Year{ get; set; }
		public int? End_Year{ get; set; }
		public System.Guid? ApplicationCode{ get; set; }
		public string Application_NO{ get; set; }
		public string DocNo{ get; set; }
		public string Log { get; set; }
	    public bool? ISActive { get; set; }
	}
}
