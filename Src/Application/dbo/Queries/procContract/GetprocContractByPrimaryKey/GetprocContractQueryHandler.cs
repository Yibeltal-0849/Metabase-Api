using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.dbo.Quiries.procContract.GetprocContractLoadAll;
using XOKA.Domain.Entities.dbo;
using XOKA.Domain.Interfaces;

namespace Application.dbo.Quiries.procContract.GetprocContractByPrimaryKey
{
    public class GetprocContractQueryHandler : IRequestHandler<GetprocContractByPrimaryKey, GetprocContractLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocContractQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocContractLoadAllListVm> Handle(GetprocContractByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<Contract> procContracts = await _procedureAdabter
               .Execute<Contract>("[dbo].[proc_ContractLoadByPrimaryKey]", request);
            GetprocContractLoadAllListVm vm = new GetprocContractLoadAllListVm
            {
                procContracts = _mapper.Map<IList<Contract>, IList<GetprocContractLoadAllVm>>(procContracts)
            };

            return vm;
        }
    }
}
