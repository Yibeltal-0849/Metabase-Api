using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.FixedAsset.Quiries.procFixedAssetEntrust.GetprocFixedAssetEntrustLoadAll;
using XOKA.Domain.Entities.FixedAsset;
using XOKA.Domain.Interfaces;

namespace Application.FixedAsset.Quiries.procFixedAssetEntrust.GetprocFixedAssetEntrustByPrimaryKey
{
    public class GetprocFixedAssetEntrustQueryHandler : IRequestHandler<GetprocFixedAssetEntrustByPrimaryKey, GetprocFixedAssetEntrustLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocFixedAssetEntrustQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocFixedAssetEntrustLoadAllListVm> Handle(GetprocFixedAssetEntrustByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<FixedAssetEntrust> procFixedAssetEntrusts = await _procedureAdabter
               .Execute<FixedAssetEntrust>("[FixedAsset].[proc_Fixed_Asset_EntrustLoadByPrimaryKey]", request);
            GetprocFixedAssetEntrustLoadAllListVm vm = new GetprocFixedAssetEntrustLoadAllListVm
            {
                procFixedAssetEntrusts = _mapper.Map<IList<FixedAssetEntrust>, IList<GetprocFixedAssetEntrustLoadAllVm>>(procFixedAssetEntrusts)
            };

            return vm;
        }
    }
}
