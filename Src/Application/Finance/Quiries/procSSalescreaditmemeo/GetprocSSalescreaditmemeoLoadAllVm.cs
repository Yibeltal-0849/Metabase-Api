using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Quiries.procSSalescreaditmemeo
{
    public class GetprocSSalescreaditmemeoLoadAllVm : IMapFrom<SSalesCreaditMemeo>
    {
        public string Sales_Credit_Line_Id { get; set; }
        public int? Qty_to_Assign { get; set; }
        public int? Qty_Assigned { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<SSalesCreaditMemeo, GetprocSSalescreaditmemeoLoadAllVm>();
        }
    }
}
