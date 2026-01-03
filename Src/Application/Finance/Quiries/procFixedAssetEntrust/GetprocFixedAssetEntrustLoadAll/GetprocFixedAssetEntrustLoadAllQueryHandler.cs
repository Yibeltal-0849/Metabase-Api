using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.procFixedAssetEntrust.GetprocFixedAssetEntrustLoadAll
{
    class GetprocFixedAssetEntrustLoadAllQueryHandler : IRequestHandler<GetprocFixedAssetEntrustLoadAllQuery, GetprocFixedAssetEntrustLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocFixedAssetEntrustLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocFixedAssetEntrustLoadAllListVm> Handle(GetprocFixedAssetEntrustLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<FixedAssetEntrust> procFixedAssetEntrusts = await _procedureAdabter
               .Execute<FixedAssetEntrust>("[FINA].[proc_Fixed_Asset_EntrustLoadAll]");
            GetprocFixedAssetEntrustLoadAllListVm vm = new GetprocFixedAssetEntrustLoadAllListVm
            {
                procFixedAssetEntrusts = _mapper.Map<IList<FixedAssetEntrust>, IList<GetprocFixedAssetEntrustLoadAllVm>>(procFixedAssetEntrusts)
            };

            return vm;
        }
    }
}
