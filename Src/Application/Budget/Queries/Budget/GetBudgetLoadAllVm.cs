using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Budget;

namespace Application.Budget.Queries.Budget
{
    public class GetBudgetLoadAllVm : IMapFrom<_Budget>
    {


        public long Budget_ID { get; set; }
        public System.Guid? organization_code { get; set; }
        public int? Year { get; set; }
        public double? Total_Budget_Amount_In_Birr { get; set; }
        public System.Guid? StatusType { get; set; }
        public System.Guid? ApplicationCode { get; set; }
        public string Application_NO { get; set; }
        public string DocNo { get; set; }
        public string Log { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<_Budget, GetBudgetLoadAllVm>();
        }
    }
}
