using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Quiries.procGeneralPostingSetups
{
    public class GetprocGeneralPostingSetupsLoadAllVm : IMapFrom<GeneralPostingSetups2>
    {
        public string Gen_Bus_Posting_Group { get; set; }
        public string Gen_Pord_Posting_Group { get; set; }
        public string Sales_Account { get; set; }
        public string Sales_Credit_Memo_Account { get; set; }
        public string Sales_Line_Disc_Account { get; set; }
        public string Sales_Inv_Disc_Account { get; set; }
        public string Sales_pmt_Disc_Debit_Account { get; set; }
        public string Sales_pmt_tol_debit_Account { get; set; }
        public string Sales_pmt_Tol_credit_Account { get; set; }
        public string Sales_Prepayment_Account { get; set; }
        public string Purch_Account { get; set; }
        public string Purch_credit_Memo_Account { get; set; }
        public string Purch_Line_Disc_Account { get; set; }
        public string Purch_pmt_Disc_debit_Account { get; set; }
        public string Purch_FA_Disc_Account { get; set; }
        public string Purch_pmt_tol_debit_Account { get; set; }
        public string Purch_pmt_tol_Credit_Account { get; set; }
        public string Purch_prepayments_Account { get; set; }
        public string INV_COGS_Account { get; set; }
        public string INV_COGS_Account_Interim { get; set; }
        public string INV_Adjmt_Account { get; set; }
        public string INV_Accrual_Account_Interim { get; set; }
        public string Direct_Cost_Applied_Account { get; set; }
        public string Overhead_Applied_Account { get; set; }
        public string Purchase_Variance_Account { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<GeneralPostingSetups2, GetprocGeneralPostingSetupsLoadAllVm>();
        }
    }
}
