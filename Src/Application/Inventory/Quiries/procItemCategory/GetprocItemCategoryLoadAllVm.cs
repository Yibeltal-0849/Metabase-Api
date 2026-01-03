using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Inventory;

namespace Application.Inventory.Quiries.procItemCategory
{
    public class GetprocItemCategoryLoadAllVm : IMapFrom<Item_Category>
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public string Gen_Pord_Posting_Group { get; set; }
        public string Inventory_Posting_Group { get; set; }
        public string TAX_Prod_Posting_Group { get; set; }
        public string Cost_Method { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<Item_Category, GetprocItemCategoryLoadAllVm>();
        }
    }
}
