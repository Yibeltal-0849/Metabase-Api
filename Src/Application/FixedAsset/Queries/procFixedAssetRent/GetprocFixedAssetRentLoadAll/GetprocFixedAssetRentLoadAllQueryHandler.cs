using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.FixedAsset;
using XOKA.Domain.Interfaces;

namespace Application.FixedAsset.Quiries.procFixedAssetRent.GetprocFixedAssetRentLoadAll
{
    class GetprocFixedAssetRentLoadAllQueryHandler : IRequestHandler<GetprocFixedAssetRentLoadAllQuery, GetprocFixedAssetRentLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocFixedAssetRentLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocFixedAssetRentLoadAllListVm> Handle(GetprocFixedAssetRentLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<FixedAssetRent> procFixedAssetRents = await _procedureAdabter
               .Execute<FixedAssetRent>("[FixedAsset].[proc_Fixed_Asset_RentLoadAll]");
            GetprocFixedAssetRentLoadAllListVm vm = new GetprocFixedAssetRentLoadAllListVm
            {
                procFixedAssetRents = _mapper.Map<IList<FixedAssetRent>, IList<GetprocFixedAssetRentLoadAllVm>>(procFixedAssetRents)
            };

            return vm;
        }
    }
}
