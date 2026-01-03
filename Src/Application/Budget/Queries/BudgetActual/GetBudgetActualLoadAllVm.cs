using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Budget;

namespace Application.Budget.Queries.BudgetActual
{
    public class GetBudgetActualLoadAllVm : IMapFrom<Budget_Actual>
    {

        public long Budget_ActualID { get; set; }
        public string Budget_DetailID { get; set; }
        public string Account_ID { get; set; }
        public double? Actual_Cost { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Budget_Actual, GetBudgetActualLoadAllVm>();
        }
    }
}
