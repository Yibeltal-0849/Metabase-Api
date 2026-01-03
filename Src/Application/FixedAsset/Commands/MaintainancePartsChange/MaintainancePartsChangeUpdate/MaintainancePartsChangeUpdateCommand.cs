using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.FixedAsset;
using XOKA.Domain.Interfaces;

namespace Application.FixedAsset.Commands.MaintainancePartsChange.MaintainancePartsChangeUpdate.MaintainancePartsChangeUpdateCommand
{

	/// @author  Shimels Alem  Maintainance_PartsChangeUpdate stored procedure.


	public class MaintainancePartsChangeUpdateCommand : IRequest<IList<MaintainancePartsChange_PartsCange_ID>>
    {
        public System.Int64 PartsCange_ID { get; set; }
        public string Maintainance_ID { get; set; }
        public double? Unit_Cost { get; set; }
        public double? Quantity { get; set; }
        public double? Total_Cost { get; set; }
        public string Transfer_Req_DetailID { get; set; }
        public string Item_ID { get; set; }
        public bool? IsChanged { get; set; }
    }
		
		
		 
	}

