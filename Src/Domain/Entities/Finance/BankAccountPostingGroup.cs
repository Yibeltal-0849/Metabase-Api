namespace XOKA.Domain.Entities.Finance
{
    public class BankAccountPostingGroup
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Account_ID { get; set; }
        public string Orgid { get; set; }
        public System.Guid? Branch { get; set; }
        public bool? dufault { get; set; }
    }
}
