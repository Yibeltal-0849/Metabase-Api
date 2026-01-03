


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Inventory;

namespace Application.Inventory.Commands.cItems.cItemsInsert.cItemsInsertCommand
{

    /// @author  Shimels Alem  c_ItemsInsert stored procedure.


    public class cItemsInsertCommand : IRequest<IList<C_Items_Item_Id>>
    {
        public string Item_Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string OrgCode { get; set; }
        public string Item_Type { get; set; }
        public string Json_Meta_Data { get; set; }
        public string Json_Data { get; set; }
        public string Log { get; set; }
        public string Application_No { get; set; }
        public System.DateTime? Created_Date { get; set; }
        public System.Guid? Created_By { get; set; }

    }



}
 
 