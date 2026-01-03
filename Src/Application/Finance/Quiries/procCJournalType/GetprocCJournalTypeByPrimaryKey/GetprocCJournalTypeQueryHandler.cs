using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Finance.Quiries.procCJournalType.GetprocCJournalTypeLoadAll;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.procCJournalType.GetprocCJournalTypeByPrimaryKey
{
    public class GetprocCJournalTypeQueryHandler : IRequestHandler<GetprocCJournalTypeByPrimaryKey, GetprocCJournalTypeLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocCJournalTypeQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocCJournalTypeLoadAllListVm> Handle(GetprocCJournalTypeByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<CJournalType> procCJournalTypes = await _procedureAdabter
               .Execute<CJournalType>("[FINA].[proc_C_Journal_TypeLoadByPrimaryKey]", request);
            GetprocCJournalTypeLoadAllListVm vm = new GetprocCJournalTypeLoadAllListVm
            {
                procCJournalTypes = _mapper.Map<IList<CJournalType>, IList<GetprocCJournalTypeLoadAllVm>>(procCJournalTypes)
            };

            return vm;
        }
    }
}
