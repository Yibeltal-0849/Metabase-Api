using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Quiries.procStoreItemActivityType
{
    public class GetprocStoreItemActivityTypeLoadAllVm : IMapFrom<_procStoreItemActivityType>
    {

		public string Code { get; set; }
		public string Name { get; set; }
		public string ID_Numbring { get; set; }
		public string JsonMeta_For_Detail { get; set; }
		public System.Guid? Visable_For_Task_ID { get; set; }
		public string Order { get; set; }
		public string Group_Branch { get; set; }
		public string Mandatory_Column_Name { get; set; }
		public bool? IsActive { get; set; }
		public string Lased_Numbe_Used { get; set; }
		public System.DateTime? Last_Number_Used_Date { get; set; }

		public void Mapping(Profile profile)
        {
            profile.CreateMap<_procStoreItemActivityType, GetprocStoreItemActivityTypeLoadAllVm>();
        }
    }
}
