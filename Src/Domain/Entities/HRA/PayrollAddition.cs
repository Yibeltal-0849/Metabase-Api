using System;

namespace XOKA.Domain.Entities.HRA
{
    public class PayrollAddition
    {
        public Guid Addion_ID { get; set; }
        public Guid Pos_ID { get; set; }
        public Guid Addition_Type { get; set; }
        public string Unit { get; set; }
        public int? QTY { get; set; }
        public double? Unit_Price { get; set; }
       
        public bool? Is_Active { get; set; }
        public bool? Is_Personal { get; set; }
       
    }
}
