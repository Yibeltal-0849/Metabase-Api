using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.ProprtyData.Queries.proctblConsumer.GetproctblConsumerLoadAll;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Queries.proctblConsumer.GetproctblConsumerByPrimaryKey
{
    public class GetproctblConsumerQueryHandler : IRequestHandler<GetproctblConsumerByPrimaryKey, GetproctblConsumerLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetproctblConsumerQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproctblConsumerLoadAllListVm> Handle(GetproctblConsumerByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<tblConsumer> proctblConsumers = await _procedureAdabter
               .Execute<tblConsumer>("[ProprtyData].[proc_tblConsumerLoadByPrimaryKey]", request);
            GetproctblConsumerLoadAllListVm vm = new GetproctblConsumerLoadAllListVm
            {
                proctblConsumers = _mapper.Map<IList<tblConsumer>, IList<GetproctblConsumerLoadAllVm>>(proctblConsumers)
            };

            return vm;
        }
    }
}
