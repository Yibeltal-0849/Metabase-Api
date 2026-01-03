


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.FixedAsset;

namespace Application.FixedAsset.Commands.MaintainancePartsChange.MaintainancePartsChangeInsert.MaintainancePartsChangeInsertCommand
{

    /// @author  Shimels Alem  Maintainance_PartsChangeInsert stored procedure.


    public class MaintainancePartsChangeInsertCommand : IRequest<IList<MaintainancePartsChange_PartsCange_ID>>
    {
        public System.Int64? PartsCange_ID { get; set; }
        public string Maintainance_ID { get; set; }
        public double? Unit_Cost { get; set; }
        public double? Quantity { get; set; }
        public double? Total_Cost { get; set; }
        public string Transfer_Req_DetailID { get; set; }
        public string Item_ID { get; set; }
        public bool? IsChanged { get; set; }
    }
		
		
		 
	}
 
 