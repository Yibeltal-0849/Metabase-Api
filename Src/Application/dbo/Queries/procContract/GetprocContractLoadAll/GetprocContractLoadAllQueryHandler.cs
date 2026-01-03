using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.dbo;
using XOKA.Domain.Interfaces;

namespace Application.dbo.Quiries.procContract.GetprocContractLoadAll
{
    class GetprocContractLoadAllQueryHandler : IRequestHandler<GetprocContractLoadAllQuery, GetprocContractLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocContractLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocContractLoadAllListVm> Handle(GetprocContractLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<Contract> procContracts = await _procedureAdabter
               .Execute<Contract>("[dbo].[proc_ContractLoadAll]");
            GetprocContractLoadAllListVm vm = new GetprocContractLoadAllListVm
            {
                procContracts = _mapper.Map<IList<Contract>, IList<GetprocContractLoadAllVm>>(procContracts)
            };

            return vm;
        }
    }
}
