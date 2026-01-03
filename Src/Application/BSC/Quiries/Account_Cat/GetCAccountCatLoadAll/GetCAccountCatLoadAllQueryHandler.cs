using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Bsc;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.BSC.Quiries.Account_Cat.GetCAccountCatLoadAll
{
    public class GetCAccountCatLoadAllQueryHandler : IRequestHandler<GetCAccountCatLoadAllQuery, GetCAccountCatLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetCAccountCatLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetCAccountCatLoadAllListVm> Handle(GetCAccountCatLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<Proc_C_Account_Cat> accountCats = await _procedureAdabter
               .Execute<Proc_C_Account_Cat>("[BSC].[proc_c_Account_CatLoadAll]");
            GetCAccountCatLoadAllListVm vm = new GetCAccountCatLoadAllListVm
            {
                AccountCats = _mapper.Map<IList<Proc_C_Account_Cat>, IList<GetCAccountCatLoadAllVM>>(accountCats)
            };

            return vm;
        }
    }
}
