



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;


namespace Application.Finance.Commands.procMaintainancePartsChange.procMaintainancePartsChangeInsert.procMaintainancePartsChangeInsertCommand
{

    /// @author  Shimels Alem  proc_Maintainance_PartsChangeInsert stored procedure.


    public class procMaintainancePartsChangeInsertHandler : IRequestHandler<procMaintainancePartsChangeInsertCommand, IList<MaintainancePartsChange_PartsCange_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procMaintainancePartsChangeInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<MaintainancePartsChange_PartsCange_ID>> Handle( procMaintainancePartsChangeInsertCommand request, CancellationToken cancellationToken)
        {

            IList<MaintainancePartsChange_PartsCange_ID> result = await _procedureAdabter
                .Execute<MaintainancePartsChange_PartsCange_ID>("[FINA].proc_Maintainance_PartsChangeInsert", request);
           

            return result;
        }
    }
}
 