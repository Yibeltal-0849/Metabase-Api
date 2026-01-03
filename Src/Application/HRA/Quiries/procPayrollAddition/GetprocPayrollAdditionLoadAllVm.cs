using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.HRA;

namespace Application.HRA.Quiries.procPayrollAddition
{
    public class GetprocPayrollAdditionLoadAllVm : IMapFrom<PayrollAddition>
    {
        public Guid Addion_ID { get; set; }
        public Guid Pos_ID { get; set; }
        public Guid Addition_Type { get; set; }
        public string Unit { get; set; }
        public int? QTY { get; set; }
        public double? Unit_Price { get; set; }
        
        public bool? Is_Active { get; set; }
        public bool? Is_Personal { get; set; }
      
        public void Mapping(Profile profile)
        {
            profile.CreateMap<PayrollAddition, GetprocPayrollAdditionLoadAllVm>();
        }
    }
}
