using System;
using System.Collections.Generic;
using System.Text;

namespace XOKA.Domain.Entities.Bsc
{
    public class Proc_C_Bank_Deposit
    {
        public string Bank_Name { get; set; }
        public string Vocher_No { get; set; }
        public System.DateTime? Deposit_Ticket_Date { get; set; }
        public string Deposit_Ticket_ID { get; set; }
        public string Amount { get; set; }
        public System.Guid Id { get; set; }
        public System.Guid UserID { get; set; }
        public bool Is_EPayment { get; set; }
    }
}
