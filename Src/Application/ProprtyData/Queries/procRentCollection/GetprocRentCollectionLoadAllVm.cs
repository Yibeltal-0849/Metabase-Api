using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Queries.procRentCollection
{
    public class GetprocRentCollectionLoadAllVm : IMapFrom<RentCollection>
    {
		public System.Guid Rent_Collection_ID { get; set; }
		public System.Guid Rent_Contract_ID { get; set; }
		public System.Guid Month { get; set; }
		public System.DateTime? Start_Date { get; set; }
		public System.DateTime? End_date { get; set; }
		public bool? Collected { get; set; }
		public string Referance_NO { get; set; }
		public void Mapping(Profile profile)
        {
            profile.CreateMap<RentCollection, GetprocRentCollectionLoadAllVm>();
        }
    }
}
