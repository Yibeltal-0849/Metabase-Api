using System;

namespace XOKA.Domain.Entities.HRA
{
    public class bankDetail
    {
        public Guid bankid { get; set; }
        public string Employee_Id { get; set; }
        public string BankName { get; set; }
        public string AccountNumber { get; set; }
        public string AccountHolderName { get; set; }
        public string BranchName { get; set; }
        public string IFSCCode { get; set; }
        public string SwiftCode { get; set; }
        public string BankAddress { get; set; }
        public string Country { get; set; }
       // public string BankDetail_Type_Posting_Group { get; set; }
    }
}
