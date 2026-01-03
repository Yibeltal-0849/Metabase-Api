using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Queries.proctblConsumptionTransaction
{
    public class GetproctblConsumptionTransactionLoadAllVm : IMapFrom<tblConsumptionTransaction>
    {
        public string Tranaction_Id { get; set; }
        public DateTime? Start_Date { get; set; }
        public DateTime? End_Date { get; set; }
        public bool? Complited { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<tblConsumptionTransaction, GetproctblConsumptionTransactionLoadAllVm>();
        }
    }
}
