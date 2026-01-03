using System;

namespace XOKA.Domain.Entities.HRA
{
    public class PayrollAdditionType
    {
        public Guid Addition_Type_code { get; set; }
        public string Name { get; set; }
        public bool? Is_Taxable { get; set; }
        public double? Min_Value { get; set; }
        public double? Max_Value { get; set; }
        public string GL_Account { get; set; }
        public bool? Is_Active { get; set; }
    }
}
