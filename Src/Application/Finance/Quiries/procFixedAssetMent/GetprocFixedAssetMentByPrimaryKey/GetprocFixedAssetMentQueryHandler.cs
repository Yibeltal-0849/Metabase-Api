using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Finance.Quiries.procFixedAssetMent.GetprocFixedAssetMentLoadAll;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.procFixedAssetMent.GetprocFixedAssetMentByPrimaryKey
{
    public class GetprocFixedAssetMentQueryHandler : IRequestHandler<GetprocFixedAssetMentByPrimaryKey, GetprocFixedAssetMentLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocFixedAssetMentQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocFixedAssetMentLoadAllListVm> Handle(GetprocFixedAssetMentByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<FixedAssetMent> procFixedAssetMents = await _procedureAdabter
               .Execute<FixedAssetMent>("[FINA].[proc_Fixed_Asset_MentLoadByPrimaryKey]", request);
            GetprocFixedAssetMentLoadAllListVm vm = new GetprocFixedAssetMentLoadAllListVm
            {
                procFixedAssetMents = _mapper.Map<IList<FixedAssetMent>, IList<GetprocFixedAssetMentLoadAllVm>>(procFixedAssetMents)
            };

            return vm;
        }
    }
}
