using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Finance.Quiries.procC2BPaymentQueryRequest.GetC2BPaymentQueryRequestLoadAll;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.procC2BPaymentQueryRequest.GetC2BPaymentQueryRequesByPrimaryKey
{
    public class GetprocC2BPaymentQueryRequestByPrimaryKeyQueryHandler : IRequestHandler<GetC2BPaymentRequestByPrimaryKey, GetC2BPaymentQueryRequestLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocC2BPaymentQueryRequestByPrimaryKeyQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetC2BPaymentQueryRequestLoadAllListVm> Handle(GetC2BPaymentRequestByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<C2BPaymentQueryRequest> procC2BPaymentQueryRequest = await _procedureAdabter
               .Execute<C2BPaymentQueryRequest>("[FINA].[C2BPaymentQueryRequest]", request);
            GetC2BPaymentQueryRequestLoadAllListVm vm = new GetC2BPaymentQueryRequestLoadAllListVm
            {
                procC2BPaymentQueryRequest = _mapper.Map<IList<C2BPaymentQueryRequest>, IList<GetC2BPaymentQueryRequestLoadAllVm>>(procC2BPaymentQueryRequest)
            };

            return vm;
        }
    }
}
