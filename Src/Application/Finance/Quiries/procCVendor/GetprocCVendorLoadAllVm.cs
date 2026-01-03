using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Quiries.procCVendor
{
    public class GetprocCVendorLoadAllVm : IMapFrom<CVendor>
    {
        public string Vendor_ID { get; set; }
        public string Org_Code { get; set; }
        public string Customer_ID { get; set; }
        public string Name { get; set; }
        public string Postal_code { get; set; }
        public Nullable<System.Guid> Country { get; set; }
        public string Contact { get; set; }
        public string Sales_Person_code { get; set; }
        public string Telephone_Office { get; set; }
        public string Mobile { get; set; }
        public string email { get; set; }
        public string Address { get; set; }
        public string Website { get; set; }
        public Nullable<bool> Price_Including_VAT { get; set; }
        public Nullable<double> PrePayment_Per { get; set; }
        public string TIN { get; set; }
        public string Payment_Terms_Code { get; set; }
        public string Payment_Method_code { get; set; }
        public string Fin_Charge_Terms_code { get; set; }
        public Nullable<System.DateTime> Last_Date_Modified { get; set; }
        public string Last_statement_No { get; set; }
        public Nullable<double> Credit_Limit { get; set; }
        public string Sales_Tax_Type { get; set; }
        public string Expense_Account { get; set; }
        public string Vendor_Posting_Group { get; set; }
        public string Gen_Bus_Posting_Group { get; set; }
        public string Vendor_Psting_Group { get; set; }
        public Nullable<System.Guid> UserId { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<CVendor, GetprocCVendorLoadAllVm>();
        }
    }
}
