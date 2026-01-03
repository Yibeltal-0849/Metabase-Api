using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Application.BSC.Quiries.Currency_ID.GetCCurrencyIDLoadAll;
using XOKA.Domain.Entities.Bsc;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.BSC.Quiries.Currency_ID.GetCCurrencyIDByPrimaryKey
{
    class GetCCurrencyIDQueryHandler : IRequestHandler<GetCCurrencyIDByPrimaryKey, GetCCurrencyIDLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetCCurrencyIDQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetCCurrencyIDLoadAllListVm> Handle(GetCCurrencyIDByPrimaryKey request, CancellationToken cancellationToken)
        {
            string CurrencyID = request.CurrencyID;
            IList<Proc_C_Currency_ID> currencyIDs = await _procedureAdabter
               .Execute<Proc_C_Currency_ID>("[BSC].[proc_C_Currency_IDLoadByPrimaryKey]", (nameof(CurrencyID), CurrencyID));
            GetCCurrencyIDLoadAllListVm vm = new GetCCurrencyIDLoadAllListVm
            {
                CurrencyIDs = _mapper.Map<IList<Proc_C_Currency_ID>, IList<GetCCurrencyIDLoadAllVm>>(currencyIDs)
            };

            return vm;
        }
    }
}
