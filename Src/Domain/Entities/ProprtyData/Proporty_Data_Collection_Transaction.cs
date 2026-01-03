
using System;

namespace XOKA.Domain.Entities.ProprtyData
{
    public partial class Proporty_Data_Collection_Transaction
    {
        public System.Guid Trans_ID { get; set; }
        public string Property_ID { get; set; }
        public Nullable<System.DateTime> Transaction_Date { get; set; }
        public Nullable<System.Guid> Collected_by_user { get; set; }
        public string Dinamic_Form_Data { get; set; }
        public string Location { get; set; }
        public Nullable<bool> Approved { get; set; }
    }
}
