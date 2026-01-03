using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.FixedAsset;
using XOKA.Domain.Interfaces;

namespace Application.FixedAsset.Quiries.procFixedAssetMent.GetprocFixedAssetMentLoadAll
{
    class GetprocFixedAssetMentLoadAllQueryHandler : IRequestHandler<GetprocFixedAssetMentLoadAllQuery, GetprocFixedAssetMentLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocFixedAssetMentLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocFixedAssetMentLoadAllListVm> Handle(GetprocFixedAssetMentLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<FixedAssetMent> procFixedAssetMents = await _procedureAdabter
               .Execute<FixedAssetMent>("[FixedAsset].[proc_Fixed_Asset_MentLoadAll]");
            GetprocFixedAssetMentLoadAllListVm vm = new GetprocFixedAssetMentLoadAllListVm
            {
                procFixedAssetMents = _mapper.Map<IList<FixedAssetMent>, IList<GetprocFixedAssetMentLoadAllVm>>(procFixedAssetMents)
            };

            return vm;
        }
    }
}
