using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Quiries.proccTurmsAndCredit
{
    public class GetproccTurmsAndCreditLoadAllVm : IMapFrom<CTurmsAndCredit>
    {

        public long Id { get; set; }
        public string Org_id { get; set; }
        public bool? C_O_D { get; set; }
        public bool? Prepaid { get; set; }
        public bool? Due_in_Number_of_Days { get; set; }
        public bool? Due_on_Day_of_next_Month { get; set; }
        public bool? Due_at_end_of_month { get; set; }
        public int? Due_on_the_Next_Month { get; set; }
        public int? Net_Due_in_day { get; set; }
        public int? Discount_in_days { get; set; }
        public int? Discount_Percent { get; set; }
        public decimal? Creadit_Limit { get; set; }
        public long? Creadit_Status { get; set; }
        public string GL_Sales_Account { get; set; }
        public string Discount_GL_Account { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<CTurmsAndCredit, GetproccTurmsAndCreditLoadAllVm>();
        }
    }
}
