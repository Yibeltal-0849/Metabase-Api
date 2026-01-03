using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Quiries.GetAvalable_Discount
{
    public class Avalable_Discount : IMapFrom<AvalableDiscount>
    {
        public string Code { get; set; }
        public string Due_Date_Calculation { get; set; }
        public string Discount_Date_Calculation { get; set; }
        public Nullable<double> Discount_Per { get; set; }
        public Nullable<bool> Calc_Pmt_Disc_on_Cr_Memos { get; set; }
        public string Description { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<AvalableDiscount, Avalable_Discount>();
        }
    }
}
