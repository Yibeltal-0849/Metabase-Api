using AutoMapper;
using MediatR;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.procFixedAssetEntrust.procFixedAssetEntrustDelete.procFixedAssetEntrustDeleteCommand
{

    /// @author  Shimels Alem  proc_Fixed_Asset_EntrustDelete stored procedure.


    public class procFixedAssetEntrustDeleteHandler : IRequestHandler<procFixedAssetEntrustDeleteCommand, IList<FixedAssetEntrust_Entrust_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procFixedAssetEntrustDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<FixedAssetEntrust_Entrust_ID>> Handle( procFixedAssetEntrustDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<FixedAssetEntrust_Entrust_ID> result = await _procedureAdabter
                .Execute<FixedAssetEntrust_Entrust_ID>("[FINA].proc_Fixed_Asset_EntrustDelete", request);
           

            return result;
        }
    }
}
  