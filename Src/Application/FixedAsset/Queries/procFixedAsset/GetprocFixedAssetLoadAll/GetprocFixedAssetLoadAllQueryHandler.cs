using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.FixedAsset;
using XOKA.Domain.Interfaces;

namespace Application.FixedAsset.Quiries.procFixedAsset.GetprocFixedAssetLoadAll
{
    class GetprocFixedAssetLoadAllQueryHandler : IRequestHandler<GetprocFixedAssetLoadAllQuery, GetprocFixedAssetLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocFixedAssetLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocFixedAssetLoadAllListVm> Handle(GetprocFixedAssetLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<Fixed_Asset> procFixedAssets = await _procedureAdabter
               .Execute<Fixed_Asset>("[FixedAsset].[proc_Fixed_AssetLoadAll]");
            GetprocFixedAssetLoadAllListVm vm = new GetprocFixedAssetLoadAllListVm
            {
                procFixedAssets = _mapper.Map<IList<Fixed_Asset>, IList<GetprocFixedAssetLoadAllVm>>(procFixedAssets)
            };

            return vm;
        }
    }
}
