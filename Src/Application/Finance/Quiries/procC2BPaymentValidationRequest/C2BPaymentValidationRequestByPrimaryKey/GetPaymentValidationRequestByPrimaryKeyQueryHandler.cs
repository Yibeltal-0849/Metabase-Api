using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Finance.Quiries.procC2BPaymentValidationRequest.GetC2BPaymentValidationRequestLoadAll;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.procC2BPaymentValidationRequest.GetEmplyeeTypePostingGroupByPrimaryKeyQueryHandler
{
    public class GetPaymentValidationRequestByPrimaryKeyQueryHandler : IRequestHandler<GetPaymentValidationRequestByPrimaryKey, GetC2BPaymentValidationRequestLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetPaymentValidationRequestByPrimaryKeyQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetC2BPaymentValidationRequestLoadAllListVm> Handle(GetPaymentValidationRequestByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<C2BPaymentValidationRequest> procC2BPaymentValidationRequest = await _procedureAdabter
               .Execute<C2BPaymentValidationRequest>("[FINA].[C2BPaymentValidationRequest]", request);
            GetC2BPaymentValidationRequestLoadAllListVm vm = new GetC2BPaymentValidationRequestLoadAllListVm
            {
                procC2BPaymentValidationRequest = _mapper.Map<IList<C2BPaymentValidationRequest>, IList<GetC2BPaymentValidationRequestLoadAllVm>>(procC2BPaymentValidationRequest)
            };

            return vm;
        }
    }
}
