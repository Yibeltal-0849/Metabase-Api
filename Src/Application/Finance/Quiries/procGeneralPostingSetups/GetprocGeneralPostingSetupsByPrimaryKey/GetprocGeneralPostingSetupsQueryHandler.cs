using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Finance.Quiries.procGeneralPostingSetups.GetprocGeneralPostingSetupsLoadAll;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.procGeneralPostingSetups.GetprocGeneralPostingSetupsByPrimaryKey
{
    public class GetprocGeneralPostingSetupsQueryHandler : IRequestHandler<GetprocGeneralPostingSetupsByPrimaryKey, GetprocGeneralPostingSetupsLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocGeneralPostingSetupsQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocGeneralPostingSetupsLoadAllListVm> Handle(GetprocGeneralPostingSetupsByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<GeneralPostingSetups2> procGeneralPostingSetupss = await _procedureAdabter
               .Execute<GeneralPostingSetups2>("[FINA].[proc_General Posting SetupsLoadByPrimaryKey]", request);
            GetprocGeneralPostingSetupsLoadAllListVm vm = new GetprocGeneralPostingSetupsLoadAllListVm
            {
                procGeneralPostingSetupss = _mapper.Map<IList<GeneralPostingSetups2>, IList<GetprocGeneralPostingSetupsLoadAllVm>>(procGeneralPostingSetupss)
            };

            return vm;
        }
    }
}
