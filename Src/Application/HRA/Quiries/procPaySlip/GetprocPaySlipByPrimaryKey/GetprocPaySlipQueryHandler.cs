using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.HRA.Quiries.procPaySlip.GetprocPaySlipLoadAll;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.HRA.Quiries.procPaySlip.GetprocPaySlipByPrimaryKey
{
    public class GetprocPaySlipQueryHandler : IRequestHandler<GetprocPaySlipByPrimaryKey, GetprocPaySlipLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocPaySlipQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocPaySlipLoadAllListVm> Handle(GetprocPaySlipByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<PaySlip> procPaySlips = await _procedureAdabter
               .Execute<PaySlip>("[HRA].[proc_Pay_SlipLoadByPrimaryKey]", request);
            GetprocPaySlipLoadAllListVm vm = new GetprocPaySlipLoadAllListVm
            {
                procPaySlips = _mapper.Map<IList<PaySlip>, IList<GetprocPaySlipLoadAllVm>>(procPaySlips)
            };

            return vm;
        }
    }
}
