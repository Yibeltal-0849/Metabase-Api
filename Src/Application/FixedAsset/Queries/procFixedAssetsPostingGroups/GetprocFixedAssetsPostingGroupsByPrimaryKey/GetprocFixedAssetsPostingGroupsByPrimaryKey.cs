using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.FixedAsset.Quiries.procFixedAssetsPostingGroups.GetprocFixedAssetsPostingGroupsLoadAll;

namespace Application.FixedAsset.Quiries.procFixedAssetsPostingGroups.GetprocFixedAssetsPostingGroupsByPrimaryKey
{
    /// @author  Shimels Alem proc_Fixed_Assets_Posting_GroupsLoadByPrimaryKey stored procedure.

    public class GetprocFixedAssetsPostingGroupsByPrimaryKey : IRequest<GetprocFixedAssetsPostingGroupsLoadAllListVm>
    {
		public string Code { get; set; }
		public string Name { get; set; }
		public double Dep_Per { get; set; }
		public System.Int32 Dep_Max_Year { get; set; }
		public string Acquisition_Cost_Account { get; set; }
		public string Dep_Expeance_GL_Account { get; set; }
		public string Dep_Acc_GLAccount { get; set; }
		public string Acquisitioncostsondisposal { get; set; }
		public string Accumulateddepreciationondisposal { get; set; }
		public string Gainsondisposal { get; set; }
		public string Lossesondisposal { get; set; }
		public string Maintenanceexpenses { get; set; }
		public string Depreciationexpenses { get; set; }
		public string Rent_Inc_GL_Account { get; set; }
		public double Dep_IFRS_Per { get; set; }
		public System.Int32 IFRS_Dep_Max_Year { get; set; }
		public string IFRS_Expeance_GL_Account { get; set; }
		public string IFRS_Dep_Acc_GLAccount { get; set; }
		public string IFRS_Acquisitioncostsondisposal { get; set; }
		public string IFRSAccumulateddepreciationondisposal { get; set; }
		public string IFRSGainsondisposal { get; set; }
		public string IFRSLossesondisposal { get; set; }
		public string IFRSMaintenanceexpenses { get; set; }
		public string IFRSDepreciationexpenses { get; set; }
		public string IFRS_Rent_Inc_GL_Account { get; set; }
		public string ID_Numbering { get; set; }
		public double Min_Book_Value { get; set; }
		public double IFRS_Min_Book_Value { get; set; }
	}
}
