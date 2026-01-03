using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.dbo;

namespace Application.dbo.Quiries.procPropertyRegistration
{
    public class GetprocPropertyRegistrationLoadAllVm : IMapFrom<PropertyRegistration>
    {
		public string Property_ID { get; set; }
		public string Description { get; set; }
		public string Plot_ID { get; set; }
		public System.DateTime? Registration_Date { get; set; }
		public int? Property_Type_ID { get; set; }
		public int? Basement_Floor_No { get; set; }
		public int? Upper_Floor_No { get; set; }
		public System.Double? Parking_Area_M2 { get; set; }
		public decimal? Estimated_Price { get; set; }
		public System.Double? Building_Size_M2 { get; set; }
		public System.Double? Compound_Size_M2 { get; set; }
		public int? Property_Status_ID { get; set; }
		public string Property_Parent_ID { get; set; }
		public System.String Map_Floor_Plan { get; set; }
		public string Application_No { get; set; }
		public System.Guid? Licence_Service_ID { get; set; }
		public int? Number_of_Lift { get; set; }
		public string Building_No { get; set; }
		public string HouseNo { get; set; }
		public string Location_of_Property { get; set; }
		public int? Floor_No { get; set; }
		public System.Double? Size_In_Proportional { get; set; }
		public System.Double? Proportional_from_Compound_Size { get; set; }
		public System.Guid? Created_By { get; set; }
		public System.Guid? Updated_By { get; set; }
		public System.Guid? Deleted_By { get; set; }
		public bool? Is_Deleted { get; set; }
		public System.DateTime? Created_Date { get; set; }
		public System.DateTime? Updated_Date { get; set; }
		public System.DateTime? Deleted_Date { get; set; }
		
		public void Mapping(Profile profile)
        {
            profile.CreateMap<PropertyRegistration, GetprocPropertyRegistrationLoadAllVm>();
        }
    }
}
