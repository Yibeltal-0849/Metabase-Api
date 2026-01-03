 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Inventory;

namespace Application.Inventory.Commands.ItemReturnVocher.ItemReturnVocherDelete.ItemReturnVocherDeleteCommand
{

    // @author  Shimels Alem  Item_Return_VocherDelete stored procedure.


    public class ItemReturnVocherDeleteCommand : IRequest<IList<ItemReturnVocher_Requsition_ID>>
    {
        public string Requsition_ID { get; set; }
    }
		
     
		
		 
	}
 
 