


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Commands.procRentContract.procRentContractInsert.procRentContractInsertCommand
{

    /// @author  Shimels Alem  proc_Rent_ContractInsert stored procedure.


    public class procRentContractInsertCommand : IRequest<IList<RentContract_Rent_Contract_ID>>
    {
        public System.Guid Rent_Contract_ID { get; set; }
        public string Property_ID { get; set; }
        public Nullable<System.Guid> From_Organization_Code { get; set; }
        public Nullable<System.Guid> Rent_Contract_Type { get; set; }
        public Nullable<System.Guid> Service_Code { get; set; }
        public Nullable<System.Guid> Application_Code { get; set; }
        public string Application_NO { get; set; }
        public string To_Customer { get; set; }
        public string Currency { get; set; }
        public string Unit { get; set; }
        public Nullable<double> Price { get; set; }
        public Nullable<System.DateTime> Start_Date { get; set; }
        public Nullable<System.DateTime> End_Date { get; set; }
        public Nullable<bool> Renew_Year { get; set; }
        public Nullable<System.Guid> Renew_Contract_Document_Detail_ID { get; set; }
        public System.Guid Main_Contract_Document_Detail_ID { get; set; }
        public Nullable<System.Guid> Parent_Contact { get; set; }
        public Nullable<bool> Terminate { get; set; }
        public Nullable<bool> Terminate_Remark { get; set; }
        public Nullable<bool> Active { get; set; }
        public Nullable<bool> Active_Remark { get; set; }
        public string Referance_Letter { get; set; }
        public Nullable<System.Guid> Document_ID { get; set; }
        public string Contract_NO { get; set; }
    }
		
		
		 
}
 
 