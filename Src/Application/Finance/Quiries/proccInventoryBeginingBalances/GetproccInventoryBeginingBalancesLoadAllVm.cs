using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Quiries.proccInventoryBeginingBalances
{
    public class GetproccInventoryBeginingBalancesLoadAllVm : IMapFrom<CInventoryBeginingBalances>
    {
        public long Id { get; set; }
        public System.DateTime? Period { get; set; }
        public string OrgId { get; set; }
        public string Item_ID { get; set; }
        public string Description { get; set; }
        public decimal? Quantitiy { get; set; }
        public decimal? UnitCost { get; set; }
        public decimal? TotalCost { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<CInventoryBeginingBalances, GetproccInventoryBeginingBalancesLoadAllVm>();
        }
    }
}
