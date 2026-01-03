using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Purchase;
using XOKA.Domain.Interfaces;

namespace Application.Purchase.Quiries.PerchaseContract.GetPerchaseContractLoadAll
{
    class GetPerchaseContractLoadAllQueryHandler : IRequestHandler<GetPerchaseContractLoadAllQuery, GetPerchaseContractLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetPerchaseContractLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetPerchaseContractLoadAllListVm> Handle(GetPerchaseContractLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<Perchase_Contract> PerchaseContracts = await _procedureAdabter
               .Execute<Perchase_Contract>("[Purchase].[proc_Perchase_ContractLoadAll]");
            GetPerchaseContractLoadAllListVm vm = new GetPerchaseContractLoadAllListVm
            {
                PerchaseContracts = _mapper.Map<IList<Perchase_Contract>, IList<GetPerchaseContractLoadAllVm>>(PerchaseContracts)
            };

            return vm;
        }
    }
}
