namespace XOKA.Domain.Entities.view
{
    public class ViewBSCBudgetDetailGrid
    {
        public string Budget_DetailID { get; set; }
        public long Budget_ID { get; set; }
        public int? Year { get; set; }
        public string Budget_Type { get; set; }
        public string Expenditure { get; set; }
        public string DIV_code_Name { get; set; }
        public string Unit { get; set; }
        public System.Guid? ParentBuget_Detail_ID { get; set; }
        public bool? Is_Approved { get; set; }
        public double? Budget_Ammount_Birr { get; set; }
        public System.Guid? ApplicationCode { get; set; }
        public string Application_NO { get; set; }
        public string Description { get; set; }
        public string Innitiative_ID { get; set; }
        public System.Guid? Budget_Allocation_Type { get; set; }
    }
}
