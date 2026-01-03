namespace XOKA.Domain.Entities.HRA
{
    public class PayrollDeduction
    {
        public System.Guid? Diduction_ID { get; set; }
        public System.Guid? Pos_ID { get; set; }
        public System.Guid? Diducation_Type { get; set; }
        public string Unit { get; set; }
        public int? QTY { get; set; }
        public double? Unit_Price { get; set; }
        //public double? Total_Amount { get; set; }
        //public System.DateTime? StartDate { get; set; }
        //public System.DateTime? End_Date { get; set; }
        public bool? is_Active { get; set; }
        public string Remark { get; set; }
        public bool? Is_Personal { get; set; }
        //public System.Guid Employee_ID { get; set; }
    }
}
