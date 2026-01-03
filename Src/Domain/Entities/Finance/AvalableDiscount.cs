using System;
using System.Collections.Generic;
using System.Text;

namespace XOKA.Domain.Entities.Finance
{
   public  class AvalableDiscount
    {
        public string Code { get; set; }
        public string Due_Date_Calculation { get; set; }
        public string Discount_Date_Calculation { get; set; }
        public Nullable<double> Discount_Per { get; set; }
        public Nullable<bool> Calc_Pmt_Disc_on_Cr_Memos { get; set; }
        public string Description { get; set; }

    }
}
