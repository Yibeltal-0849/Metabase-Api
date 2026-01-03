using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Application.BSC.Quiries.Account_Cat.GetCAccountCatLoadAll;
using XOKA.Domain.Entities.Bsc;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.BSC.Quiries.Account_Cat.GetCAccountCatByPrimaryKey
{
    public class GetCAccountCatQueryHandler : IRequestHandler<GetCAccountCatByPrimaryKey, GetCAccountCatLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetCAccountCatQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetCAccountCatLoadAllListVm> Handle(GetCAccountCatByPrimaryKey request, CancellationToken cancellationToken)
        {
            int Code = request.Code;
            IList<Proc_C_Account_Cat> accountCats = await _procedureAdabter
               .Execute<Proc_C_Account_Cat>("[BSC].[proc_c_Account_CatLoadByPrimaryKey]", (nameof(Code), Code));
            GetCAccountCatLoadAllListVm vm = new GetCAccountCatLoadAllListVm
            {
                AccountCats = _mapper.Map<IList<Proc_C_Account_Cat>, IList<GetCAccountCatLoadAllVM>>(accountCats)
            };

            return vm;
        }
    }
}
