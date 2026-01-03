

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.FixedAsset;
using XOKA.Domain.Interfaces;

namespace Application.FixedAsset.Commands.FixedAssetRent.FixedAssetRentUpdate.FixedAssetRentUpdateCommand
{

    /// @author  Shimels Alem  proc_Fixed_Asset_RentUpdate stored procedure.


    public class FixedAssetRentUpdateHandler : IRequestHandler<FixedAssetRentUpdateCommand, IList<FixedAssetRent_Rent_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public FixedAssetRentUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<FixedAssetRent_Rent_ID>> Handle( FixedAssetRentUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<FixedAssetRent_Rent_ID> result = await _procedureAdabter
                .Execute<FixedAssetRent_Rent_ID>("[FixedAsset].proc_Fixed_Asset_RentUpdate", request);
           

            return result;
        }
    }
}
 