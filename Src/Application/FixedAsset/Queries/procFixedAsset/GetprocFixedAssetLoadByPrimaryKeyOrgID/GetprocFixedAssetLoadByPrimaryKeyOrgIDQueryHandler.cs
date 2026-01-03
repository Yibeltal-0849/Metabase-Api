using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.FixedAsset.Quiries.procFixedAsset.GetprocFixedAssetLoadAll;
using XOKA.Domain.Entities.FixedAsset;
using XOKA.Domain.Interfaces;

namespace Application.FixedAsset.Quiries.procFixedAsset.GetprocFixedAssetLoadByPrimaryKeyOrgID
{
    public class GetprocFixedAssetQueryHandler : IRequestHandler<GetprocFixedAssetLoadByPrimaryKeyOrgID, GetprocFixedAssetLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocFixedAssetQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocFixedAssetLoadAllListVm> Handle(GetprocFixedAssetLoadByPrimaryKeyOrgID request, CancellationToken cancellationToken)
        {
           
            IList<Fixed_Asset> procFixedAssets = await _procedureAdabter
               .Execute<Fixed_Asset>("[FixedAsset].[proc_Fixed_AssetLoadByPrimaryKey_OrgID]", request);
            GetprocFixedAssetLoadAllListVm vm = new GetprocFixedAssetLoadAllListVm
            {
                procFixedAssets = _mapper.Map<IList<Fixed_Asset>, IList<GetprocFixedAssetLoadAllVm>>(procFixedAssets)
            };

            return vm;
        }
    }
}
