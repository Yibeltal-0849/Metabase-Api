using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.procGenPostingType.GetprocGenPostingTypeLoadAll
{
    class GetprocGenPostingTypeLoadAllQueryHandler : IRequestHandler<GetprocGenPostingTypeLoadAllQuery, GetprocGenPostingTypeLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocGenPostingTypeLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocGenPostingTypeLoadAllListVm> Handle(GetprocGenPostingTypeLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<GenPostingType> procGenPostingTypes = await _procedureAdabter
               .Execute<GenPostingType>("[FINA].[proc_Gen_Posting_TypeLoadAll]");
            GetprocGenPostingTypeLoadAllListVm vm = new GetprocGenPostingTypeLoadAllListVm
            {
                procGenPostingTypes = _mapper.Map<IList<GenPostingType>, IList<GetprocGenPostingTypeLoadAllVm>>(procGenPostingTypes)
            };

            return vm;
        }
    }
}
