using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Finance.Quiries.GetAvalable_credits.Avalable_creditby;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;
using Application.Finance.Quiries.GetAvalable_credit;

namespace Application.Finance.Quiries.Avalable_credits.Avalable_creditListVms
{
    public class GetAvalable_creditQueryHandler : IRequestHandler<GetAvalable_credit, Avalable_creditListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetAvalable_creditQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<Avalable_creditListVm> Handle(GetAvalable_credit request, CancellationToken cancellationToken)
        {
           
            IList<AvalableDiscount> AvalableDiscount = await _procedureAdabter
               .Execute<AvalableDiscount>("[Inventory].[Avalable_credit]", request);
            Avalable_creditListVm vm = new Avalable_creditListVm
            {
                AvalableDiscount = _mapper.Map<IList<AvalableDiscount>, IList<Avalable_credit>>(AvalableDiscount)
            };

            return vm;
        }
    }
}
