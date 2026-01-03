using System;
using System.Collections.Generic;
using System.Text;

namespace XOKA.Domain.Entities.Bsc
{
    public class Proc_C_Currency_ID
    {
        public string CurrencyID{ get; set; }
		public string Name{ get; set; }
		public long? Enable{ get; set; }
		public double? Current_Value_To_Birr { get; set; }
    }
}
