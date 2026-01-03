

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


    public class MaintainancePartsChangeUpdateHandler : IRequestHandler<MaintainancePartsChangeUpdateCommand, IList<MaintainancePartsChange_PartsCange_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public MaintainancePartsChangeUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<MaintainancePartsChange_PartsCange_ID>> Handle( MaintainancePartsChangeUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<MaintainancePartsChange_PartsCange_ID> result = await _procedureAdabter
                .Execute<MaintainancePartsChange_PartsCange_ID>("[FixedAsset].Maintainance_PartsChangeUpdate", request);
           

            return result;
        }
    }
}
 