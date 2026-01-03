using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Finance.Quiries.procJ_Payroll_Journal.GetprocJ_Payroll_JournalLoadAll;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.procJ_Payroll_Journal.GetprocJ_Payroll_JournalByPrimaryKey
{
    public class GetprocJ_Payroll_JournalQueryHandler : IRequestHandler<GetprocJ_Payroll_JournalByPrimaryKey, GetprocJ_Payroll_JournalLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocJ_Payroll_JournalQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocJ_Payroll_JournalLoadAllListVm> Handle(GetprocJ_Payroll_JournalByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<J_Payroll_Journal> procJ_Payroll_Journals = await _procedureAdabter
               .Execute<J_Payroll_Journal>("[FINA].[proc_J_Payroll_JournalLoadByPrimaryKey]", request);
            GetprocJ_Payroll_JournalLoadAllListVm vm = new GetprocJ_Payroll_JournalLoadAllListVm
            {
                procJ_Payroll_Journals = _mapper.Map<IList<J_Payroll_Journal>, IList<GetprocJ_Payroll_JournalLoadAllVm>>(procJ_Payroll_Journals)
            };

            return vm;
        }
    }
}
