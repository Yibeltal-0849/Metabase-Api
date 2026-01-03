using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Inventory;
using XOKA.Domain.Interfaces;

namespace Application.Inventory.Commands.cItems.cItemsUpdate.cItemsUpdateCommand
{

	/// @author  Shimels Alem  c_ItemsUpdate stored procedure.


	public class cItemsUpdateCommand : IRequest<IList<C_Items_Item_Id>>
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

