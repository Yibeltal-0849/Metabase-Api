using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.ProprtyData.Queries.procRentCollection.GetprocRentCollectionLoadAll;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Queries.procRentCollection.GetprocRentCollectionByPrimaryKey
{
    public class GetprocRentCollectionQueryHandler : IRequestHandler<GetprocRentCollectionByPrimaryKey, GetprocRentCollectionLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocRentCollectionQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocRentCollectionLoadAllListVm> Handle(GetprocRentCollectionByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<RentCollection> procRentCollections = await _procedureAdabter
               .Execute<RentCollection>("[ProprtyData].[proc_Rent_CollectionLoadByPrimaryKey]", request);
            GetprocRentCollectionLoadAllListVm vm = new GetprocRentCollectionLoadAllListVm
            {
                procRentCollections = _mapper.Map<IList<RentCollection>, IList<GetprocRentCollectionLoadAllVm>>(procRentCollections)
            };

            return vm;
        }
    }
}
