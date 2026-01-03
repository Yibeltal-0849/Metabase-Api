using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.proccPaymentMethod.GetproccPaymentMethodLoadAll
{
    class GetproccPaymentMethodLoadAllQueryHandler : IRequestHandler<GetproccPaymentMethodLoadAllQuery, GetproccPaymentMethodLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetproccPaymentMethodLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproccPaymentMethodLoadAllListVm> Handle(GetproccPaymentMethodLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<CPaymentMethod> proccPaymentMethods = await _procedureAdabter
               .Execute<CPaymentMethod>("[FINA].[proc_c_PaymentMethodLoadAll]");
            GetproccPaymentMethodLoadAllListVm vm = new GetproccPaymentMethodLoadAllListVm
            {
                proccPaymentMethods = _mapper.Map<IList<CPaymentMethod>, IList<GetproccPaymentMethodLoadAllVm>>(proccPaymentMethods)
            };

            return vm;
        }
    }
}
