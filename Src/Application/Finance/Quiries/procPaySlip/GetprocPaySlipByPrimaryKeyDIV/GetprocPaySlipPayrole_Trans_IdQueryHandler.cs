using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Finance.Quiries.procPaySlip.GetprocPaySlipLoadAll;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.procPaySlip.GetprocPaySlipByPrimaryKeyPayrole_Trans_Id
{
    public class GetprocPaySlipPayrole_Trans_IdQueryHandler : IRequestHandler<GetprocPaySlipByPrimaryKeyPayrole_Trans_Id, GetprocPaySlipLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocPaySlipPayrole_Trans_IdQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocPaySlipLoadAllListVm> Handle(GetprocPaySlipByPrimaryKeyPayrole_Trans_Id request, CancellationToken cancellationToken)
        {
           
            IList<PaySlip> procPaySlips = await _procedureAdabter
               .Execute<PaySlip>("[FINA].[proc_Pay_SlipLoadByPayrole_Trans_Id]", request);
            GetprocPaySlipLoadAllListVm vm = new GetprocPaySlipLoadAllListVm
            {
                procPaySlips = _mapper.Map<IList<PaySlip>, IList<GetprocPaySlipLoadAllVm>>(procPaySlips)
            };

            return vm;
        }
    }
}
