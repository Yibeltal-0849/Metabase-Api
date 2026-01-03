using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.proccAccountCat.GetproccAccountCatLoadAll
{
    class GetproccAccountCatLoadAllQueryHandler : IRequestHandler<GetproccAccountCatLoadAllQuery, GetproccAccountCatLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetproccAccountCatLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproccAccountCatLoadAllListVm> Handle(GetproccAccountCatLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<CAccountCat> proccAccountCats = await _procedureAdabter
               .Execute<CAccountCat>("[FINA].[proc_c_Account_CatLoadAll]");
            GetproccAccountCatLoadAllListVm vm = new GetproccAccountCatLoadAllListVm
            {
                proccAccountCats = _mapper.Map<IList<CAccountCat>, IList<GetproccAccountCatLoadAllVm>>(proccAccountCats)
            };

            return vm;
        }
    }
}
