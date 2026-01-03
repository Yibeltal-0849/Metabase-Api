using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Quiries.proccPayrollTaxes
{
    public class GetproccPayrollTaxesLoadAllVm : IMapFrom<CPayrollTaxes>
    {


        public long Id { get; set; }
        public string Orgcode { get; set; }
        public string TaxAgencyCode { get; set; }
        public string Tax_Liability_Acc_No { get; set; }
        public string Tax_Expense_Axx_No { get; set; }
        public string Compnay_Contribution { get; set; }
        public string Employe_Contribution { get; set; }
        public string Pen_Company_GL { get; set; }
        public string Pen_Employe_GL { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<CPayrollTaxes, GetproccPayrollTaxesLoadAllVm>();
        }
    }
}
