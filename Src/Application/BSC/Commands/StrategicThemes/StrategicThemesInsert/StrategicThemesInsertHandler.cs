using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Bsc;
using XOKA.Domain.Interfaces;

namespace Application.BSC.Commands.StrategicThemes.StrategicThemesInsert.StrategicThemesInsertCommand
{ 
	 
      public class StrategicThemesInsertHandler : IRequestHandler<StrategicThemesInsertCommand, IList<Strategic_Themes_Strategic_ThemeID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public StrategicThemesInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Strategic_Themes_Strategic_ThemeID>> Handle( StrategicThemesInsertCommand request, CancellationToken cancellationToken)
        {

            IList<Strategic_Themes_Strategic_ThemeID> result = await _procedureAdabter
                .Execute<Strategic_Themes_Strategic_ThemeID>("[BSC].Strategic_ThemesInsert", request);
         
            return result;
        }
    }
}
 
