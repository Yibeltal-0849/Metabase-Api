using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Queries.procProportyDataCollectionTransaction
{
    public class GetprocProportyDataCollectionTransactionLoadAllVm : IMapFrom<Proporty_Data_Collection_Transaction>
    {
        public System.Guid Trans_ID { get; set; }
        public string Property_ID { get; set; }
        public Nullable<System.DateTime> Transaction_Date { get; set; }
        public Nullable<System.Guid> Collected_by_user { get; set; }
        public string Dinamic_Form_Data { get; set; }
        public string Location { get; set; }
        public Nullable<bool> Approved { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Proporty_Data_Collection_Transaction, GetprocProportyDataCollectionTransactionLoadAllVm>();
        }
    }
}
