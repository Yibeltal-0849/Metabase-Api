using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Entities.HRA;

namespace Application.Finance.Quiries.procPayrollAddition
{
    public class GetprocPayrollAdditionLoadAllVm : IMapFrom<PayrollAddition>
    {
        public string Addion_ID { get; set; }
        public string Emplyee_ID { get; set; }
        public string Addition_Type { get; set; }
        public string Unit { get; set; }
        public int? QTY { get; set; }
        public double? Unit_Price { get; set; }
        public double Amount { get; set; }
        public System.DateTime? Start_Date { get; set; }
        public System.DateTime? End_Date { get; set; }
        public bool? Is_Active { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<PayrollAddition, GetprocPayrollAdditionLoadAllVm>();
        }
    }
}
