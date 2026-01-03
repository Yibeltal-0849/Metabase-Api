



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;


namespace Application.ProprtyData.Commands.procRentCollection.procRentCollectionInsert.procRentCollectionInsertCommand
{

    /// @author  Shimels Alem  proc_Rent_CollectionInsert stored procedure.


    public class procRentCollectionInsertHandler : IRequestHandler<procRentCollectionInsertCommand, IList<RentCollection_Month>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procRentCollectionInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<RentCollection_Month>> Handle( procRentCollectionInsertCommand request, CancellationToken cancellationToken)
        {

            IList<RentCollection_Month> result = await _procedureAdabter
                .Execute<RentCollection_Month>("[ProprtyData].proc_Rent_CollectionInsert", request);

            return result;
        }
    }
}
 