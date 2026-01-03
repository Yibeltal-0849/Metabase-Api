using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Bsc;
using XOKA.Domain.Interfaces;

namespace Application.BSC.Quiries.StrategicThemes.GetStrategicThemesLoadAll
{
    class GetStrategicThemesLoadAllQueryHandler : IRequestHandler<GetStrategicThemesLoadAllQuery, GetStrategicThemesLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetStrategicThemesLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetStrategicThemesLoadAllListVm> Handle(GetStrategicThemesLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<Strategic_Themes> StrategicThemess = await _procedureAdabter
               .Execute<Strategic_Themes>("[BSC].[proc_Strategic_ThemesLoadAll]");
            GetStrategicThemesLoadAllListVm vm = new GetStrategicThemesLoadAllListVm
            {
                StrategicThemess = _mapper.Map<IList<Strategic_Themes>, IList<GetStrategicThemesLoadAllVm>>(StrategicThemess)
            };

            return vm;
        }
    }
}
