using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.HRA;

namespace XOKA.Application.HRA.Commands.Payrole_Transaction.CreatePayrole_Transaction
{
    /// @author  Shimels Alem  proc_Payrole_TransactionInsert stored procedure.

    public class CreatePayrole_TransactionCommand : IRequest<IList<PayroleTransaction_Payrole_Trans_Id>>
    {
        public Guid Payrole_Trans_Id { get; set; }
        public string Period { get; set; }
        public DateTime? start_Date { get; set; }
        public DateTime? End_date { get; set; }
        public string Month { get; set; }
        public bool? For_Permanent { get; set; }
        public bool? Generate { get; set; }
        public string Archived_Pay_Slip { get; set; }
        public string Application_Number { get; set; }
        public Guid? Applicaation_Code { get; set; }
        public Guid? to_do_code { get; set; }
        public string username { get; set; }
    }
}
