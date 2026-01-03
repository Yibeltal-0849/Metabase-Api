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

namespace Application.Finance.Quiries.procorganizations.Getprocorganizationsbyname
{
    public class GetprocorganizationsLoadByBranchQueryHandler : IRequestHandler<Getprocorganizationsbyname, GetprocorganizationsLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocorganizationsLoadByBranchQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocorganizationsLoadAllListVm> Handle(Getprocorganizationsbyname request, CancellationToken cancellationToken)
        {
           
            IList<_procorganizations> procorganizationss = await _procedureAdabter
               .Execute<_procorganizations>("[dbo].[proc_organizationsLoadByname]", request);
            GetprocorganizationsLoadAllListVm vm = new GetprocorganizationsLoadAllListVm
            {
                procorganizationss = _mapper.Map<IList<_procorganizations>, IList<GetprocorganizationsLoadAllVm>>(procorganizationss)
            };

            return vm;
        }
    }
}
