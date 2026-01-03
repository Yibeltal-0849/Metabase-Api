using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.FixedAsset;
using XOKA.Domain.Interfaces;

namespace Application.Vehicle.Commands.MaintainancePartsChange.MaintainancePartsChangeDelete.MaintainancePartsChangeDeleteCommand
{

    ///   @author  Shimels Alem proc_Maintainance_PartsChangeDelete stored procedure.

    public class MaintainancePartsChangeDeleteCommand : IRequest<IList<MaintainancePartsChange_PartsCange_ID>>
    {
        public Int64 PartsCange_ID { get; set; }
    }
		
}
 
 
