using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Finance.Quiries.GetAvalable_Discounts.Avalable_Discountby;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;
using Application.Finance.Quiries.GetAvalable_Discount;

namespace Application.Finance.Quiries.Avalable_Discounts.Avalable_DiscountListVms
{
    public class GetAvalable_DiscountQueryHandler : IRequestHandler<GetAvalable_Discount, Avalable_DiscountListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetAvalable_DiscountQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<Avalable_DiscountListVm> Handle(GetAvalable_Discount request, CancellationToken cancellationToken)
        {
           
            IList<AvalableDiscount> AvalableDiscount = await _procedureAdabter
               .Execute<AvalableDiscount>("[FINA].[Avalable_Discount]", request);
            Avalable_DiscountListVm vm = new Avalable_DiscountListVm
            {
                AvalableDiscount = _mapper.Map<IList<AvalableDiscount>, IList<Avalable_Discount>>(AvalableDiscount)
            };

            return vm;
        }
    }
}
