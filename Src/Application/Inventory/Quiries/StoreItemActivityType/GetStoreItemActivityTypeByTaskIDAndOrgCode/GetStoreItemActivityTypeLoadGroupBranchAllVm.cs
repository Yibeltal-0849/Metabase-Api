using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Inventory;

namespace Application.Inventory.Quiries.StoreItemActivityType.GetStoreItemActivityTypeByTaskIDAndOrgCode
{
    public class GetStoreItemActivityTypeLoadGroupBranchAllVm : IMapFrom<Store_Item_Activity_Type_Group_Branch>
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string ID_Numbring { get; set; }
        public string JsonMeta_For_Detail { get; set; }
        public System.Guid? Visable_For_Task_ID { get; set; }
        public string Order { get; set; }
        public string Mandatory_Column_Name { get; set; }
        public bool? IsActive { get; set; }
        public System.Guid? Orgnization_Code { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<Store_Item_Activity_Type_Group_Branch, GetStoreItemActivityTypeLoadGroupBranchAllVm>();
        }
    }
}
