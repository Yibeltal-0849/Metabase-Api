using AutoMapper;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Interfaces;
using System.Collections.Generic;
using XOKA.Domain.Entities.Purchase;

namespace Application.Purchase.Commands.ContractType.procContractTypeUpdate
{
    public class procContractTypeUpdateHandler : IRequestHandler<procContractTypeUpdateCommand, IList<ReciveContractType_Code>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procContractTypeUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<ReciveContractType_Code>> Handle(procContractTypeUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<ReciveContractType_Code> result = await _procedureAdabter
                .Execute<ReciveContractType_Code>("[Purchase].[Contract_TypeUpdate]", request);


            return result;
        }
    }
}
