using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.procPJobLineType.GetprocPJobLineTypeLoadAll
{
    class GetprocPJobLineTypeLoadAllQueryHandler : IRequestHandler<GetprocPJobLineTypeLoadAllQuery, GetprocPJobLineTypeLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocPJobLineTypeLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocPJobLineTypeLoadAllListVm> Handle(GetprocPJobLineTypeLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<PJobLineType> procPJobLineTypes = await _procedureAdabter
               .Execute<PJobLineType>("[FINA].[proc_P_Job_Line_TypeLoadAll]");
            GetprocPJobLineTypeLoadAllListVm vm = new GetprocPJobLineTypeLoadAllListVm
            {
                procPJobLineTypes = _mapper.Map<IList<PJobLineType>, IList<GetprocPJobLineTypeLoadAllVm>>(procPJobLineTypes)
            };

            return vm;
        }
    }
}
