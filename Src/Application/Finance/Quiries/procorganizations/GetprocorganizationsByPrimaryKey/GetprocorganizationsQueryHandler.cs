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

namespace Application.Finance.Quiries.procorganizations.GetprocorganizationsByPrimaryKey
{
    public class GetprocorganizationsQueryHandler : IRequestHandler<GetprocorganizationsByPrimaryKey, GetprocorganizationsLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocorganizationsQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocorganizationsLoadAllListVm> Handle(GetprocorganizationsByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<_procorganizations> procorganizationss = await _procedureAdabter
               .Execute<_procorganizations>("[dbo].[proc_organizationsLoadByPrimaryKey]", request);
            GetprocorganizationsLoadAllListVm vm = new GetprocorganizationsLoadAllListVm
            {
                procorganizationss = _mapper.Map<IList<_procorganizations>, IList<GetprocorganizationsLoadAllVm>>(procorganizationss)
            };

            return vm;
        }
    }
}
