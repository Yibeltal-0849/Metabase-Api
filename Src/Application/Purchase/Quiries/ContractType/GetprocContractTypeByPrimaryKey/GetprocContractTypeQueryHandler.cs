using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Purchase.Quiries.ContractType.GetprocContractTypeLoadAll;
using XOKA.Domain.Entities.Purchase;
using XOKA.Domain.Interfaces;


namespace Application.Purchase.Quiries.ContractType.GetprocContractTypeByPrimaryKey
{
    public class GetprocContractTypeQueryHandler : IRequestHandler<GetprocContractTypeByPrimaryKey, GetprocContractTypeLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocContractTypeQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocContractTypeLoadAllListVm> Handle(GetprocContractTypeByPrimaryKey request, CancellationToken cancellationToken)
        {

            IList<ContractTypeD> procContractType = await _procedureAdabter
               .Execute<ContractTypeD>("[Purchase].[Contract_TypeLoadByPrimaryKey]", request);
            GetprocContractTypeLoadAllListVm vm = new GetprocContractTypeLoadAllListVm

            {
                procContractType = _mapper.Map<IList<ContractTypeD>, IList<GetprocContractTypeLoadAllVm>>(procContractType)
            };

            return vm;
        }
    }
}
