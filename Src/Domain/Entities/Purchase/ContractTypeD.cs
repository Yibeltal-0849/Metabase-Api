namespace XOKA.Domain.Entities.Purchase
{
    public class ContractTypeD
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Numbering { get; set; }
        public string Last_Numbering_used { get; set; }
        public System.DateTime Last_Numbering_Date { get; set; }
        public bool IsActive { get; set; }
        public System.Guid Organization_ID { get; set; }
    }
}
