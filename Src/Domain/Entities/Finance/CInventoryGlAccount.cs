namespace XOKA.Domain.Entities.Finance
{
    public class CInventoryGlAccount
    {
        public long id { get; set; }
        public string OrgCode { get; set; }
        public string Item_Class { get; set; }
        public string GLSales_incAcc { get; set; }
        public string GLInvtry_WageAcc { get; set; }
        public string GLCostSalesAcc { get; set; }
        public string GL_Cost_of_Good_Sold { get; set; }
        public string Costing { get; set; }
        public string ID_Numbering { get; set; }
    }
}
