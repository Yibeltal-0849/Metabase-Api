using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.HRA;

namespace Application.Finance.Quiries.procPayrollAdditionType
{
    public class GetprocPayrollAdditionTypeLoadAllVm : IMapFrom<PayrollAdditionType>
    {
        public string Addition_Type_code { get; set; }
        public string Name { get; set; }
        public bool? Is_Taxable { get; set; }
        public double? Min_Value { get; set; }
        public double? Max_Value { get; set; }
        public string GL_Account { get; set; }
        public bool? Is_Active { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<PayrollAdditionType, GetprocPayrollAdditionTypeLoadAllVm>();
        }
    }
}
