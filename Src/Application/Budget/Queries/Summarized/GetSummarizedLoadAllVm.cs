using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Budget;

namespace Application.Budget.Queries.Summarized
{
    public class GetSummarizedLoadAllVm : IMapFrom<_Summarized>
    {



        public System.Guid Budget_Summarized_ID { get; set; }
        public long Budget_ID { get; set; }
        public string Budget_Type { get; set; }
        public System.Guid organization_code { get; set; }
        public System.Guid? ParentBuget_Sum_ID { get; set; }
        public string Unit { get; set; }
        public bool? Is_Approved { get; set; }
        public double? Budget_Ammount_Birr { get; set; }
        public System.Guid? ApplicationCode { get; set; }
        public string Application_NO { get; set; }
        public string DocNo { get; set; }
        public string Log { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<_Summarized, GetSummarizedLoadAllVm>();
        }
    }
}
