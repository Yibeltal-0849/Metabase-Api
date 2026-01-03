namespace XOKA.Domain.Entities.Finance
{
    public class procorganizations_organization_Code
    {
        public System.Guid organization_Code { get; set; }
        public string name_en { get; set; }
        public string name_am { get; set; }
        public string email { get; set; }
        public string telephone { get; set; }
        public string PhysicalAddress { get; set; }
        public bool? is_active { get; set; }
        public decimal geo_Location_X { get; set; }
        public decimal geo_Location_Y { get; set; }
        public string tin { get; set; }
    }
}