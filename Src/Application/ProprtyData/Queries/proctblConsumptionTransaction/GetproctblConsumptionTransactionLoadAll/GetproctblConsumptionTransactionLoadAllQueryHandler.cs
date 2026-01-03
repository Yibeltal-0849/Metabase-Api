using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Queries.proctblConsumptionTransaction.GetproctblConsumptionTransactionLoadAll
{
    class GetproctblConsumptionTransactionLoadAllQueryHandler : IRequestHandler<GetproctblConsumptionTransactionLoadAllQuery, GetproctblConsumptionTransactionLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetproctblConsumptionTransactionLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproctblConsumptionTransactionLoadAllListVm> Handle(GetproctblConsumptionTransactionLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<tblConsumptionTransaction> proctblConsumptionTransactions = await _procedureAdabter
               .Execute<tblConsumptionTransaction>("[ProprtyData].[proc_tblConsumption_TransactionLoadAll]");
            GetproctblConsumptionTransactionLoadAllListVm vm = new GetproctblConsumptionTransactionLoadAllListVm
            {
                proctblConsumptionTransactions = _mapper.Map<IList<tblConsumptionTransaction>, IList<GetproctblConsumptionTransactionLoadAllVm>>(proctblConsumptionTransactions)
            };

            return vm;
        }
    }
}
