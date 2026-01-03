



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.FixedAsset;
using XOKA.Domain.Interfaces;


namespace Application.FixedAsset.Commands.FixedAssetRent.FixedAssetRentInsert.FixedAssetRentInsertCommand
{

    /// @author  Shimels Alem  proc_Fixed_Asset_RentInsert stored procedure.


    public class FixedAssetRentInsertHandler : IRequestHandler<FixedAssetRentInsertCommand, IList<FixedAssetRent_Rent_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public FixedAssetRentInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<FixedAssetRent_Rent_ID>> Handle( FixedAssetRentInsertCommand request, CancellationToken cancellationToken)
        {

            IList<FixedAssetRent_Rent_ID> result = await _procedureAdabter
                .Execute<FixedAssetRent_Rent_ID>("[FixedAsset].proc_Fixed_Asset_RentInsert", request);
           

            return result;
        }
    }
}
 