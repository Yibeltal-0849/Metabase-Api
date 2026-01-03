using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Quiries.procRentCollectionTransactions
{
    public class GetprocRentCollectionTransactionsLoadAllVm : IMapFrom<RentCollectionTransactions>
    {
        public System.Guid Rent_Collection_ID { get; set; }
        public System.DateTime? Period { get; set; }
        public System.DateTime? Start_Date { get; set; }
        public System.DateTime? End_date { get; set; }
        public bool? Generate { get; set; }
        public string Archived_Pay_Slip { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<RentCollectionTransactions, GetprocRentCollectionTransactionsLoadAllVm>();
        }
    }
}
