using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Quiries.procFixedAssetsPostingGroups
{
    public class GetprocFixedAssetsPostingGroupsLoadAllVm : IMapFrom<FixedAssetsPostingGroups>
    {

        public string Code { get; set; }
        public string Name { get; set; }
        public double? Dep_Per { get; set; }
        public int? Dep_Max_Year { get; set; }
        public string Acquisition_Cost_Account { get; set; }
        public string Dep_Expeance_GL_Account { get; set; }
        public string Dep_Acc_GLAccount { get; set; }
        public string Acquisition_costs_on_disposal { get; set; }
        public string Accumulated_depreciation_on_disposal { get; set; }
        public string Gains_on_disposal { get; set; }
        public string Losses_on_disposal { get; set; }
        public string Maintenance_expenses { get; set; }
        public string Depreciation_expenses { get; set; }
        public string Rent_Inc_GL_Account { get; set; }
        public double? Dep_IFRS_Per { get; set; }
        public int? IFRS_Dep_Max_Year { get; set; }
        public string IFRS_Expeance_GL_Account { get; set; }
        public string IFRS_Dep_Acc_GLAccount { get; set; }
        public string IFRS_Acquisition_costs_on_disposal { get; set; }
        public string IFRS_Accumulated_depreciation_on_disposal { get; set; }
        public string IFRS_Gains_on_disposal { get; set; }
        public string IFRS_Losses_on_disposal { get; set; }
        public string IFRS_Maintenance_expenses { get; set; }
        public string IFRS_Depreciation_expenses { get; set; }
        public string IFRS_Rent_Inc_GL_Account { get; set; }
        public string ID_Numbering { get; set; }
        public double? Min_Book_Value { get; set; }
        public double? IFRS_Min_Book_Value { get; set; }
        public bool? Is_Active { get; set; }
        public string Log { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<FixedAssetsPostingGroups, GetprocFixedAssetsPostingGroupsLoadAllVm>();
        }
    }
}
