using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.procMaintainancePartsChange.procMaintainancePartsChangeDelete.procMaintainancePartsChangeDeleteCommand
{

    /// @author  Shimels Alem  proc_Maintainance_PartsChangeDelete stored procedure.


    public class procMaintainancePartsChangeDeleteHandler : IRequestHandler<procMaintainancePartsChangeDeleteCommand, IList<MaintainancePartsChange_PartsCange_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procMaintainancePartsChangeDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<MaintainancePartsChange_PartsCange_ID>> Handle( procMaintainancePartsChangeDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<MaintainancePartsChange_PartsCange_ID> result = await _procedureAdabter
                .Execute<MaintainancePartsChange_PartsCange_ID>("[FINA].proc_Maintainance_PartsChangeDelete", request);
           

            return result;
        }
    }
}
  