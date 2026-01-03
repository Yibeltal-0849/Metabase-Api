namespace XOKA.Domain.Entities.view
{
    public class ViewInnititativeAvalableForRequest
    {
        public string Strategy_NO { get; set; }
        public System.Guid Organization_code { get; set; }
        public string Title { get; set; }
        public string Strategic_Theme { get; set; }
        public string Annual_Strategic_GoalID { get; set; }
        public int Year { get; set; }
        public System.Double Result_In_Per { get; set; }
        public string ASGD_ID { get; set; }
        public string Strategic_Goal { get; set; }
        public System.Double Goal_Value_In_Per { get; set; }
        public System.Guid Assigned_Body { get; set; }
        public string department_name { get; set; }
        public System.Guid Responsible_Role { get; set; }
        public string RoleName { get; set; }
        public string Innitiative_ID { get; set; }
        public System.Guid Type_Of_Innitiative { get; set; }
        public string Innitiative { get; set; }
        public string Description { get; set; }
        public System.Guid Innitiative_Assigned_Body_Name { get; set; }
        public string Innitiative_Assigned_Body_Role_Name { get; set; }
        public string Expr1 { get; set; }
        public System.Guid Expr2 { get; set; }
        public string Expr3 { get; set; }
        public string Expr4 { get; set; }
        public System.Double Estimated_Cost_In_Birr { get; set; }
        public System.Double Value_In_Per { get; set; }
        public string Unit { get; set; }
        public System.Double? Acctual { get; set; }



        public System.Double? Variance { get; set; }
        public System.Double Duration_In_Days { get; set; }
        public string Expected_Result { get; set; }
        public int Priority { get; set; }
        public string Required_Inputs { get; set; }
        public System.Double Estimated_Budget { get; set; }

        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public string ParentInnitiative_ID { get; set; }

    }
}
