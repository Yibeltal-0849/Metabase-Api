using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Queries.proctblEnergyChain
{
    public class GetproctblEnergyChainLoadAllVm : IMapFrom<tblEnergyChain>
    {
        public long id { get; set; }
        public string Name { get; set; }
        public string Definition { get; set; }
        public bool? Enable { get; set; }
        public System.DateTime? Created_Date { get; set; }
        public long Created_By { get; set; }
        public System.DateTime? Update_Date { get; set; }
        public long? Update_by { get; set; }
        public byte[] Last_Modified { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<tblEnergyChain, GetproctblEnergyChainLoadAllVm>();
        }
    }
}
