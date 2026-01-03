using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.ProcServiceTopics.GetProcServiceTopicsLoadAll
{
    class GetProcServiceTopicsLoadAllQueryHandler : IRequestHandler<GetProcServiceTopicsLoadAllQuery, GetProcServiceTopicsLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetProcServiceTopicsLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetProcServiceTopicsLoadAllListVm> Handle(GetProcServiceTopicsLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<Service_Topics> ProcServiceTopicss = await _procedureAdabter
               .Execute<Service_Topics>("[FINA].[proc_Service_TopicsLoadAll]");
            GetProcServiceTopicsLoadAllListVm vm = new GetProcServiceTopicsLoadAllListVm
            {
                ProcServiceTopicss = _mapper.Map<IList<Service_Topics>, IList<GetProcServiceTopicsLoadAllVm>>(ProcServiceTopicss)
            };

            return vm;
        }
    }
}
