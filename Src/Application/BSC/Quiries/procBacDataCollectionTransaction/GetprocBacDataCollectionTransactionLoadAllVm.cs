using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Bsc;

namespace Application.BSC.Quiries.procBacDataCollectionTransaction
{
    public class GetprocBacDataCollectionTransactionLoadAllVm : IMapFrom<BacDataCollectionTransaction>
    {
        public System.Guid Bsc_Tran_Data_Id { get; set; }
        public System.Guid? ApplicationCode { get; set; }
        public string Application_NO { get; set; }
        public System.Guid? KPIMapping_ID { get; set; }
        public string Year { get; set; }
        public string Perod { get; set; }
        public System.DateTime? Period_Start_Date { get; set; }
        public System.DateTime? Period_End_Date { get; set; }
        public string Innitiative_ID { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<BacDataCollectionTransaction, GetprocBacDataCollectionTransactionLoadAllVm>();
        }
    }
}
