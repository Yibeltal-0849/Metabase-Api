namespace XOKA.Domain.Entities.Finance
{
    public class CTaxPostingSetup
    {
        public string TAX_BusPosting_Group { get; set; }
        public string TAX_Prod_Psting_Group { get; set; }
        public string TAX_Per { get; set; }
        public string Sales_TAX_GL_Account { get; set; }
        public string Purchase_TAX_Account { get; set; }
        public string Reverse_Chrg_TAX_Account { get; set; }
        public bool? ISActive { get; set; }
    }
}
