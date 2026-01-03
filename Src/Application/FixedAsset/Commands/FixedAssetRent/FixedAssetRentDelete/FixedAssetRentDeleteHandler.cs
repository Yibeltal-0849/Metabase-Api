using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.FixedAsset;
using XOKA.Domain.Interfaces;

namespace Application.FixedAsset.Commands.FixedAssetRent.FixedAssetRentDelete.FixedAssetRentDeleteCommand
{

    /// @author  Shimels Alem  Fixed_Asset_RentDelete stored procedure.


    public class FixedAssetRentDeleteHandler : IRequestHandler<FixedAssetRentDeleteCommand, IList<FixedAssetRent_Rent_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public FixedAssetRentDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<FixedAssetRent_Rent_ID>> Handle( FixedAssetRentDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<FixedAssetRent_Rent_ID> result = await _procedureAdabter
                .Execute<FixedAssetRent_Rent_ID>("[FixedAsset].Fixed_Asset_RentDelete", request);
           

            return result;
        }
    }
}
  