

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;



namespace Application.Finance.Commands.procMaintainancePartsChange.procMaintainancePartsChangeUpdate.procMaintainancePartsChangeUpdateCommand
{

    /// @author  Shimels Alem  proc_Maintainance_PartsChangeUpdate stored procedure.


    public class procMaintainancePartsChangeUpdateHandler : IRequestHandler<procMaintainancePartsChangeUpdateCommand, IList<MaintainancePartsChange_PartsCange_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procMaintainancePartsChangeUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<MaintainancePartsChange_PartsCange_ID>> Handle( procMaintainancePartsChangeUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<MaintainancePartsChange_PartsCange_ID> result = await _procedureAdabter
                .Execute<MaintainancePartsChange_PartsCange_ID>("[FINA].proc_Maintainance_PartsChangeUpdate", request);
           

            return result;
        }
    }
}
 