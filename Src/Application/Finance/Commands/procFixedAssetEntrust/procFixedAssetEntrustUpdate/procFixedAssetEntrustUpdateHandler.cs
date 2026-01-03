

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;



namespace Application.Finance.Commands.procFixedAssetEntrust.procFixedAssetEntrustUpdate.procFixedAssetEntrustUpdateCommand
{

    /// @author  Shimels Alem  proc_Fixed_Asset_EntrustUpdate stored procedure.


    public class procFixedAssetEntrustUpdateHandler : IRequestHandler<procFixedAssetEntrustUpdateCommand, IList<FixedAssetEntrust_Entrust_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procFixedAssetEntrustUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<FixedAssetEntrust_Entrust_ID>> Handle( procFixedAssetEntrustUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<FixedAssetEntrust_Entrust_ID> result = await _procedureAdabter
                .Execute<FixedAssetEntrust_Entrust_ID>("[FINA].proc_Fixed_Asset_EntrustUpdate", request);
           

            return result;
        }
    }
}
 