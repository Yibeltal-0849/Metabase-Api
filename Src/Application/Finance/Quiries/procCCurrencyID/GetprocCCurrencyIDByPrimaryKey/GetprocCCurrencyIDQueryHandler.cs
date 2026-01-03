using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Finance.Quiries.procCCurrencyID.GetprocCCurrencyIDLoadAll;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.procCCurrencyID.GetprocCCurrencyIDByPrimaryKey
{
    public class GetprocCCurrencyIDQueryHandler : IRequestHandler<GetprocCCurrencyIDByPrimaryKey, GetprocCCurrencyIDLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocCCurrencyIDQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocCCurrencyIDLoadAllListVm> Handle(GetprocCCurrencyIDByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<CCurrencyId> procCCurrencyIDs = await _procedureAdabter
               .Execute<CCurrencyId>("[FINA].[proc_C_Currency_IDLoadByPrimaryKey]", request);
            GetprocCCurrencyIDLoadAllListVm vm = new GetprocCCurrencyIDLoadAllListVm
            {
                procCCurrencyIDs = _mapper.Map<IList<CCurrencyId>, IList<GetprocCCurrencyIDLoadAllVm>>(procCCurrencyIDs)
            };

            return vm;
        }
    }
}
