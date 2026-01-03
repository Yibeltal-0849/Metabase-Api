using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Quiries.procSSalseqoute
{
    public class GetprocSSalseqouteLoadAllVm : IMapFrom<SSalseQoute>
    {
        public string Sales_Qoute_Line_ID { get; set; }
        public int? Qty_to_Assign { get; set; }
        public int? Qty_Assigned { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<SSalseQoute, GetprocSSalseqouteLoadAllVm>();
        }
    }
}
