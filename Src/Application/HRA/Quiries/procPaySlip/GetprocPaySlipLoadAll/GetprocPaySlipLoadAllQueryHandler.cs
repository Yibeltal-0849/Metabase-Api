using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.HRA.Quiries.procPaySlip.GetprocPaySlipLoadAll
{
    class GetprocPaySlipLoadAllQueryHandler : IRequestHandler<GetprocPaySlipLoadAllQuery, GetprocPaySlipLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocPaySlipLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocPaySlipLoadAllListVm> Handle(GetprocPaySlipLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<PaySlip> procPaySlips = await _procedureAdabter
               .Execute<PaySlip>("[HRA].[proc_Pay_SlipLoadAll]");
            GetprocPaySlipLoadAllListVm vm = new GetprocPaySlipLoadAllListVm
            {
                procPaySlips = _mapper.Map<IList<PaySlip>, IList<GetprocPaySlipLoadAllVm>>(procPaySlips)
            };

            return vm;
        }
    }
}
