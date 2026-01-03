using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Budget;

namespace Application.Budget.Queries.BudgetType
{
    public class GetBudgetTypeLoadAllVm : IMapFrom<Budget_Type>
    {

        public string Code { get; set; }
        public string Expenditure { get; set; }
        public string Description { get; set; }
        public string AccountCode { get; set; }
        public string Parent { get; set; }
        public System.Guid? For_organization { get; set; }
        public bool? Is_Account { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Budget_Type, GetBudgetTypeLoadAllVm>();
        }
    }
}
