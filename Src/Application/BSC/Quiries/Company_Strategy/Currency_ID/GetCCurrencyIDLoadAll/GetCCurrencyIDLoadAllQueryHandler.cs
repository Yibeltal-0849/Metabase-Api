using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Bsc;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.BSC.Quiries.Currency_ID.GetCCurrencyIDLoadAll
{
    public class GetCCurrencyIDLoadAllQueryHandler : IRequestHandler<GetCCurrencyIDLoadAllQuery, GetCCurrencyIDLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetCCurrencyIDLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetCCurrencyIDLoadAllListVm> Handle(GetCCurrencyIDLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<Proc_C_Currency_ID> currencyIDs = await _procedureAdabter
               .Execute<Proc_C_Currency_ID>("[BSC].[proc_C_Currency_IDLoadAll]");
            GetCCurrencyIDLoadAllListVm vm = new GetCCurrencyIDLoadAllListVm
            {
                CurrencyIDs = _mapper.Map<IList<Proc_C_Currency_ID>, IList<GetCCurrencyIDLoadAllVm>>(currencyIDs)
            };

            return vm;
        }
    }
}
