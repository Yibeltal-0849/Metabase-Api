namespace XOKA.Domain.Entities.Finance
{
    public class CInventoryGeneralDefaults
    {
        public long id { get; set; }
        public bool? UPCSKUAllowdublicate { get; set; }
        public bool? PartNumberAllowdublicate { get; set; }
        public string EnableMultiPacks { get; set; }
        public string ItemclassDefault { get; set; }
        public string GL_Freight_Account { get; set; }
    }
}
