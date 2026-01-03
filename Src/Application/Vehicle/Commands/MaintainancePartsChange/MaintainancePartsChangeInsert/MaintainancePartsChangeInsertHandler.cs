using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.FixedAsset;
using XOKA.Domain.Interfaces;

namespace Application.Vehicle.Commands.MaintainancePartsChange.MaintainancePartsChangeInsert.MaintainancePartsChangeInsertCommand
{ 
	 
      public class MaintainancePartsChangeInsertHandler : IRequestHandler<MaintainancePartsChangeInsertCommand, IList<MaintainancePartsChange_PartsCange_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public MaintainancePartsChangeInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<MaintainancePartsChange_PartsCange_ID>> Handle( MaintainancePartsChangeInsertCommand request, CancellationToken cancellationToken)
        {

            IList<MaintainancePartsChange_PartsCange_ID> result = await _procedureAdabter
                .Execute<MaintainancePartsChange_PartsCange_ID>("[Vehicle].proc_Maintainance_PartsChangeInsert", request);
           

            return result;
        }
    }
}
 
