using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Finance.Quiries.proccAccountCat.GetproccAccountCatLoadAll;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.proccAccountCat.GetproccAccountCatByPrimaryKey
{
    public class GetproccAccountCatQueryHandler : IRequestHandler<GetproccAccountCatByPrimaryKey, GetproccAccountCatLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetproccAccountCatQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproccAccountCatLoadAllListVm> Handle(GetproccAccountCatByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<CAccountCat> proccAccountCats = await _procedureAdabter
               .Execute<CAccountCat>("[FINA].[proc_c_Account_CatLoadByPrimaryKey]", request);
            GetproccAccountCatLoadAllListVm vm = new GetproccAccountCatLoadAllListVm
            {
                proccAccountCats = _mapper.Map<IList<CAccountCat>, IList<GetproccAccountCatLoadAllVm>>(proccAccountCats)
            };

            return vm;
        }
    }
}
