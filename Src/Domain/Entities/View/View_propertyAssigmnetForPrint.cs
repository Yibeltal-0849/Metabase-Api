using System;

namespace XOKA.Domain.Entities.view
{
    public class View_propertyAssigmnetForPrint
    {
        public string? Proporty_ID { set; get; }
        public string? Orgnization_Name_Eng { set; get; }
        public string? Orgnization_Name_Am { set; get; }
        public string? Property_Type { set; get; }
        public string? full_name { set; get; }
        public Guid? Trans_ID { set; get; }
    }
}
