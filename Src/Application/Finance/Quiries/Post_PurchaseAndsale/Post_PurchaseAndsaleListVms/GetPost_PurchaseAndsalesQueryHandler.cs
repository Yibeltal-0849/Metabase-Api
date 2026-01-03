using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Finance.Quiries.Post_PurchaseAndsale.Post_PurchaseAndsaleby;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.Post_PurchaseAndsale.Post_PurchaseAndsaleListVms
{
    public class GetPost_PurchaseAndsalesQueryHandler : IRequestHandler<GetPost_PurchaseAndsales, Post_PurchaseAndsaleListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetPost_PurchaseAndsalesQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<Post_PurchaseAndsaleListVm> Handle(GetPost_PurchaseAndsales request, CancellationToken cancellationToken)
        {
           
            IList<PostPurchaseAndsale> PostPurchaseAndsale = await _procedureAdabter
               .Execute<PostPurchaseAndsale>("[FINA].[Post_PurchaseAndsale]", request);
            Post_PurchaseAndsaleListVm vm = new Post_PurchaseAndsaleListVm
            {
                PostPurchaseAndsale = _mapper.Map<IList<PostPurchaseAndsale>, IList<Post_PurchaseAndsales>>(PostPurchaseAndsale)
            };

            return vm;
        }
    }
}
