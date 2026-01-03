
using System;

namespace XOKA.Domain.Entities.ProprtyData
{
    public  class PostionLoockup
    {
        public Nullable<System.Guid> Position_ID { get; set; }
        public string description_am { get; set; }
        public string description_en { get; set; }
        public DateTime Created_Date { get; set; }
    }
}
