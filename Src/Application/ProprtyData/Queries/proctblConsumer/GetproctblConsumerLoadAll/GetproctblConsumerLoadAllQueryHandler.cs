using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Queries.proctblConsumer.GetproctblConsumerLoadAll
{
    class GetproctblConsumerLoadAllQueryHandler : IRequestHandler<GetproctblConsumerLoadAllQuery, GetproctblConsumerLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetproctblConsumerLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproctblConsumerLoadAllListVm> Handle(GetproctblConsumerLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<tblConsumer> proctblConsumers = await _procedureAdabter
               .Execute<tblConsumer>("[ProprtyData].[proc_tblConsumerLoadAll]");
            GetproctblConsumerLoadAllListVm vm = new GetproctblConsumerLoadAllListVm
            {
                proctblConsumers = _mapper.Map<IList<tblConsumer>, IList<GetproctblConsumerLoadAllVm>>(proctblConsumers)
            };

            return vm;
        }
    }
}
