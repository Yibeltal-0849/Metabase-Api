namespace XOKA.Domain.Entities.Finance
{
    public class CInsurancePlan
    {
        public long id { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public bool? IsEmploye_Pay { get; set; }
        public bool? IsCompany_Pay { get; set; }
        public long? IsBothPay { get; set; }
        public string PayPercheckper  { get; set; }
        public string GL_AccountsEmpContribution { get; set; }
        public string OrgId { get; set; }
        public string GL_AccountExp { get; set; }
        public string GL_Account_Liability { get; set; }
    }
}
