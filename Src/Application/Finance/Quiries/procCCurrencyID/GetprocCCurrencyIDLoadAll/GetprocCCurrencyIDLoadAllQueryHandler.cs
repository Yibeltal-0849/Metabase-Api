using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.procCCurrencyID.GetprocCCurrencyIDLoadAll
{
    class GetprocCCurrencyIDLoadAllQueryHandler : IRequestHandler<GetprocCCurrencyIDLoadAllQuery, GetprocCCurrencyIDLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocCCurrencyIDLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocCCurrencyIDLoadAllListVm> Handle(GetprocCCurrencyIDLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<CCurrencyId> procCCurrencyIDs = await _procedureAdabter
               .Execute<CCurrencyId>("[FINA].[proc_C_Currency_IDLoadAll]");
            GetprocCCurrencyIDLoadAllListVm vm = new GetprocCCurrencyIDLoadAllListVm
            {
                procCCurrencyIDs = _mapper.Map<IList<CCurrencyId>, IList<GetprocCCurrencyIDLoadAllVm>>(procCCurrencyIDs)
            };

            return vm;
        }
    }
}
