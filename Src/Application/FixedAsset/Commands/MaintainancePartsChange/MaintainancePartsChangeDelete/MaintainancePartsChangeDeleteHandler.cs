using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.FixedAsset;
using XOKA.Domain.Interfaces;

namespace Application.FixedAsset.Commands.MaintainancePartsChange.MaintainancePartsChangeDelete.MaintainancePartsChangeDeleteCommand
{

    /// @author  Shimels Alem  Maintainance_PartsChangeDelete stored procedure.


    public class MaintainancePartsChangeDeleteHandler : IRequestHandler<MaintainancePartsChangeDeleteCommand, IList<MaintainancePartsChange_PartsCange_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public MaintainancePartsChangeDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<MaintainancePartsChange_PartsCange_ID>> Handle( MaintainancePartsChangeDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<MaintainancePartsChange_PartsCange_ID> result = await _procedureAdabter
                .Execute<MaintainancePartsChange_PartsCange_ID>("[FixedAsset].Maintainance_PartsChangeDelete", request);
           
            return result;
        }
    }
}
  