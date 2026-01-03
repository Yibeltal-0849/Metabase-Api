

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;



namespace Application.Finance.Commands.procFixedAssetRent.procFixedAssetRentUpdate.procFixedAssetRentUpdateCommand
{

    /// @author  Shimels Alem  proc_Fixed_Asset_RentUpdate stored procedure.


    public class procFixedAssetRentUpdateHandler : IRequestHandler<procFixedAssetRentUpdateCommand, IList<FixedAssetRent_Rent_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procFixedAssetRentUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<FixedAssetRent_Rent_ID>> Handle( procFixedAssetRentUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<FixedAssetRent_Rent_ID> result = await _procedureAdabter
                .Execute<FixedAssetRent_Rent_ID>("[FINA].proc_Fixed_Asset_RentUpdate", request);
           

            return result;
        }
    }
}
 