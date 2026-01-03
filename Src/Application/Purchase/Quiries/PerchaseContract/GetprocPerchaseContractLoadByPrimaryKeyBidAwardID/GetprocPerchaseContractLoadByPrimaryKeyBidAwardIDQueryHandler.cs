using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Purchase.Quiries.PerchaseContract.GetPerchaseContractLoadAll;
using XOKA.Domain.Entities.Purchase;
using XOKA.Domain.Interfaces;

namespace Application.Purchase.Quiries.PerchaseContract.GetprocPerchaseContractLoadByPrimaryKeyBidAwardID
{
    public class GetPerchaseContractQueryHandler : IRequestHandler<GetprocPerchaseContractLoadByPrimaryKeyBidAwardID, GetPerchaseContractLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetPerchaseContractQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetPerchaseContractLoadAllListVm> Handle(GetprocPerchaseContractLoadByPrimaryKeyBidAwardID request, CancellationToken cancellationToken)
        {
           
            IList<Perchase_Contract> PerchaseContracts = await _procedureAdabter
               .Execute<Perchase_Contract>("[Purchase].[proc_Perchase_ContractLoadByPrimaryKey_Bid_Award_ID]", request);
            GetPerchaseContractLoadAllListVm vm = new GetPerchaseContractLoadAllListVm
            {
                PerchaseContracts = _mapper.Map<IList<Perchase_Contract>, IList<GetPerchaseContractLoadAllVm>>(PerchaseContracts)
            };

            return vm;
        }
    }
}
