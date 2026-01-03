namespace XOKA.Domain.Entities.HRA
{
    public class PaySlip
    {
        public System.Guid Pay_Slip_ID { get; set; }
        public System.Guid? Payrole_Trans_Id { get; set; }
        public System.Guid? Work_Info { get; set; }
        public string Employee_ID { get; set; }
        public string Payroll_NO { get; set; }
        public string Full_Name { get; set; }
        public string Job_Title { get; set; }
        public double? Basic_Salary { get; set; }
        public double? Total_Working_Days { get; set; }
        public double? Absent_Yearly_Leave_With_Pay { get; set; }
        public double? Absent_Yearly_Leave_Without_Pay { get; set; }
        public double? Absent_Sick_Leave { get; set; }
        public double? Absent_in_other_Typeof_Leave { get; set; }
        public double? Absent_Weekend_And_Holiday { get; set; }
        public double? Absent_With_Out_Approval { get; set; }
        public double? Net_Working_Days { get; set; }
        public double? OT_Price { get; set; }
        public double? Addistion_Before_Tax { get; set; }
        public double? Deduction_Before_Tax { get; set; }
        public double? Addistion_After_tax { get; set; }
        public double? Deduction_After_Tax { get; set; }
        public double? Inc_Tax { get; set; }
        public double? Pen_Tax { get; set; }
        public double? Pen_From_Company { get; set; }
        public double? Other_Didaction { get; set; }
        public string Bank_Account_No { get; set; }
        public double? Net_Salary { get; set; }
        public bool? IS_Payed { get; set; }
    }
}
