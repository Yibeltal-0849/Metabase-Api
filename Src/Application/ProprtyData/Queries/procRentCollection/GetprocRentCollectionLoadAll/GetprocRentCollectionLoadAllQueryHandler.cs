using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Queries.procRentCollection.GetprocRentCollectionLoadAll
{
    class GetprocRentCollectionLoadAllQueryHandler : IRequestHandler<GetprocRentCollectionLoadAllQuery, GetprocRentCollectionLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocRentCollectionLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocRentCollectionLoadAllListVm> Handle(GetprocRentCollectionLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<RentCollection> procRentCollections = await _procedureAdabter
               .Execute<RentCollection>("[ProprtyData].[proc_Rent_CollectionLoadAll]");
            GetprocRentCollectionLoadAllListVm vm = new GetprocRentCollectionLoadAllListVm
            {
                procRentCollections = _mapper.Map<IList<RentCollection>, IList<GetprocRentCollectionLoadAllVm>>(procRentCollections)
            };

            return vm;
        }
    }
}
