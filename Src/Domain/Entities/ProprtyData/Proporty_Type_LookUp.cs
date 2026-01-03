
using System;

namespace XOKA.Domain.Entities.ProprtyData
{
    public partial class Proporty_Type_LookUp
    {
        public int Property_Type_ID { get; set; }
        public string Property_Type { get; set; }
        public int Interval_Month { get; set; }
        public string Static_Json_from { get; set; }
        public string Dinamic_Json_form { get; set; }
        public Nullable<bool> Is_Deleted { get; set; }
    }
}
