using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Finance.Quiries.ProcServiceTopics.GetProcServiceTopicsLoadAll;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.ProcServiceTopics.GetProcServiceTopicsByPrimaryKey
{
    public class GetProcServiceTopicsQueryHandler : IRequestHandler<GetProcServiceTopicsByPrimaryKey, GetProcServiceTopicsLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetProcServiceTopicsQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetProcServiceTopicsLoadAllListVm> Handle(GetProcServiceTopicsByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<Service_Topics> ProcServiceTopicss = await _procedureAdabter
               .Execute<Service_Topics>("[FINA].[proc_Service_TopicsLoadByPrimaryKey]", request);
            GetProcServiceTopicsLoadAllListVm vm = new GetProcServiceTopicsLoadAllListVm
            {
                ProcServiceTopicss = _mapper.Map<IList<Service_Topics>, IList<GetProcServiceTopicsLoadAllVm>>(ProcServiceTopicss)
            };

            return vm;
        }
    }
}
