using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.BSC.Quiries.StrategicThemes.GetStrategicThemesLoadAll;
using XOKA.Domain.Entities.Bsc;
using XOKA.Domain.Interfaces;

namespace Application.BSC.Quiries.StrategicThemes.GetStrategicThemesByPrimaryKey
{
    public class GetStrategicThemesQueryHandler : IRequestHandler<GetStrategicThemesByPrimaryKey, GetStrategicThemesLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetStrategicThemesQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetStrategicThemesLoadAllListVm> Handle(GetStrategicThemesByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<Strategic_Themes> StrategicThemess = await _procedureAdabter
               .Execute<Strategic_Themes>("[BSC].[Strategic_ThemesLoadByPrimaryKey]", request);
            GetStrategicThemesLoadAllListVm vm = new GetStrategicThemesLoadAllListVm
            {
                StrategicThemess = _mapper.Map<IList<Strategic_Themes>, IList<GetStrategicThemesLoadAllVm>>(StrategicThemess)
            };

            return vm;
        }
    }
}
