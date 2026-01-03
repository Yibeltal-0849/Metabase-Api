
using System;

namespace XOKA.Domain.Entities.ProprtyData
{
    public  class Proporty_And_Postion
    {
        public System.Guid Id { get; set; }
        public Nullable<System.Guid> Position_ID { get; set; }
        public string Property_ID { get; set; }
        public Nullable<int> Priority { get; set; }
        public bool IsActive { get; set; }
    }
}
