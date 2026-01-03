namespace XOKA.Domain.Entities.Finance
{
    public class AdOrg
    {
        public string Code { get; set; }
        public System.Guid? organization_code { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }
        public string Telephone { get; set; }
        public string Fax { get; set; }
        public string TIN { get; set; }
        public string VAT { get; set; }
        public string EmployerFederal_ID { get; set; }
        public string Employer_Reginal_ID { get; set; }
        public long? Business_Type { get; set; }
        public string WebSite { get; set; }
        public string Email { get; set; }
        public byte[] Logo { get; set; }
        public long? Accounting_Method { get; set; }
    }
}
