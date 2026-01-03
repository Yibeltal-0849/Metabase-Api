using System;
using System.Collections.Generic;
using System.Text;

namespace XOKA.Domain.Entities.Bsc
{
    public class Proc_LGeneralLedgerEntries_Code
    {
		public Guid Branch_ID { get; set; }
		public DateTime Period { get; set; }
		public string Document_Type { get; set; }
		public string Document_No { get; set; }
	}
}
