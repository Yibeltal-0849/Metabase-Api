using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Finance.Quiries.procPJobLineType.GetprocPJobLineTypeLoadAll;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.procPJobLineType.GetprocPJobLineTypeByPrimaryKey
{
    public class GetprocPJobLineTypeQueryHandler : IRequestHandler<GetprocPJobLineTypeByPrimaryKey, GetprocPJobLineTypeLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocPJobLineTypeQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocPJobLineTypeLoadAllListVm> Handle(GetprocPJobLineTypeByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<PJobLineType> procPJobLineTypes = await _procedureAdabter
               .Execute<PJobLineType>("[FINA].[proc_P_Job_Line_TypeLoadByPrimaryKey]", request);
            GetprocPJobLineTypeLoadAllListVm vm = new GetprocPJobLineTypeLoadAllListVm
            {
                procPJobLineTypes = _mapper.Map<IList<PJobLineType>, IList<GetprocPJobLineTypeLoadAllVm>>(procPJobLineTypes)
            };

            return vm;
        }
    }
}
