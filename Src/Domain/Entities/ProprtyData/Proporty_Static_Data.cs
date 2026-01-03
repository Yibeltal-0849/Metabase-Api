
using System;

namespace XOKA.Domain.Entities.ProprtyData
{
    public partial class Proporty_Static_Data
    {
        public System.Guid ID { get; set; }
        public string Property_ID { get; set; }
        public string Static_form_Data { get; set; }
        public Nullable<System.DateTime> Collection_Date { get; set; }
        public Nullable<bool> Is_Active { get; set; }
    }
}
