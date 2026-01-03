using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Finance.Quiries.procorganizations.GetprocorganizationsLoadAll;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.procorganizations.GetprocorganizationsLoadByBranch
{
    public class GetprocorganizationsLoadByBranchQueryHandler : IRequestHandler<GetprocorganizationsLoadByBranch, GetprocorganizationsLoadAllListVm>
    {
        private readonly IMapper _mapper;
        private readonly IProcedureAdabter _procedureAdabter;

        public GetprocorganizationsLoadByBranchQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _procedureAdabter = procedureAdabter ?? throw new ArgumentNullException(nameof(procedureAdabter));
        }

        public async Task<GetprocorganizationsLoadAllListVm> Handle(GetprocorganizationsLoadByBranch request, CancellationToken cancellationToken)
        {
            IList<_procorganizations> procorganizationss = await _procedureAdabter
                .Execute<_procorganizations>("[dbo].[proc_organizationsLoadBybranch]", request); // Corrected procedure name
            GetprocorganizationsLoadAllListVm vm = new GetprocorganizationsLoadAllListVm
            {
                procorganizationss = _mapper.Map<IList<_procorganizations>, IList<GetprocorganizationsLoadAllVm>>(procorganizationss)
            };

            return vm;
        }
    }
}