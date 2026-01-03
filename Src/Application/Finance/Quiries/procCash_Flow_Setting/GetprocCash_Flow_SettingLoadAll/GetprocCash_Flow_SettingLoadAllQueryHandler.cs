using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.procCash_Flow_Setting.GetprocCash_Flow_SettingLoadAll
{
    class GetprocCash_Flow_SettingLoadAllQueryHandler : IRequestHandler<GetprocCash_Flow_SettingLoadAllQuery, GetprocCash_Flow_SettingLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocCash_Flow_SettingLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocCash_Flow_SettingLoadAllListVm> Handle(GetprocCash_Flow_SettingLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<Cash_Flow_Setting> procCash_Flow_Settings = await _procedureAdabter
               .Execute<Cash_Flow_Setting>("[FINA].[proc_Cash_Flow_SettingLoadAll]");
            GetprocCash_Flow_SettingLoadAllListVm vm = new GetprocCash_Flow_SettingLoadAllListVm
            {
                procCash_Flow_Settings = _mapper.Map<IList<Cash_Flow_Setting>, IList<GetprocCash_Flow_SettingLoadAllVm>>(procCash_Flow_Settings)
            };

            return vm;
        }
    }
}
