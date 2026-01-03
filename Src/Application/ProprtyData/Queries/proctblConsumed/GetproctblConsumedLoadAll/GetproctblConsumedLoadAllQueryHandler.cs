using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Queries.proctblConsumed.GetproctblConsumedLoadAll
{
    class GetproctblConsumedLoadAllQueryHandler : IRequestHandler<GetproctblConsumedLoadAllQuery, GetproctblConsumedLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetproctblConsumedLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproctblConsumedLoadAllListVm> Handle(GetproctblConsumedLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<tblConsumed> proctblConsumeds = await _procedureAdabter
               .Execute<tblConsumed>("[ProprtyData].[proc_tblConsumedLoadAll]");
            GetproctblConsumedLoadAllListVm vm = new GetproctblConsumedLoadAllListVm
            {
                proctblConsumeds = _mapper.Map<IList<tblConsumed>, IList<GetproctblConsumedLoadAllVm>>(proctblConsumeds)
            };

            return vm;
        }
    }
}
