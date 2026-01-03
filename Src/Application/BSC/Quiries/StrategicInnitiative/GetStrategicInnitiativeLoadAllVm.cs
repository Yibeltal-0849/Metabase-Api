using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Bsc;

namespace Application.BSC.Quiries.StrategicInnitiative
{
    public class GetStrategicInnitiativeLoadAllVm : IMapFrom<Strategic_Innitiative>
    {
		public string Innitiative_ID { get; set; }
		public Guid? ASPA_ID { get; set; }
		public Guid? Type_Of_Innitiative { get; set; }
		public string Innitiative { get; set; }
		public string Description { get; set; }
		public Double? Estimated_Cost_In_Birr { get; set; }
		public Double? Value_In_Per { get; set; }
		public string Unit { get; set; }
		public string Expected_Result { get; set; }
		public string Required_Inputs { get; set; }
		public Double? Estimated_Budget { get; set; }
		public string Budget_Account { get; set; }
		public DateTime? StartDate { get; set; }
		public DateTime? EndDate { get; set; }
		public string ParentInnitiative_ID { get; set; }
		public bool Is_Active { get; set; }
		public Guid Created_By_User { get; set; }
		public Double? Acctual { get; set; }
		public Double? Variance { get; set; }
		public Double? Duration_In_Days { get; set; }
		public Int32? Priority { get; set; }
		public Byte[] Document { get; set; }
		public Guid? Document_Details_ID { get; set; }

		public void Mapping(Profile profile)
        {
            profile.CreateMap<Strategic_Innitiative, GetStrategicInnitiativeLoadAllVm>();
        }
    }
}
