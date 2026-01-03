using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Bsc;
using XOKA.Domain.Interfaces;

namespace Application.BSC.Commands.StrategicThemes.StrategicThemesDelete.StrategicThemesDeleteCommand
{

    ///   @author  Shimels Alem Strategic_ThemesDelete stored procedure.
    public class StrategicThemesDeleteCommand : IRequest<IList<Strategic_Themes_Strategic_ThemeID>>
    {
        public string Strategic_ThemeID { get; set; }
    }
		
		 
	}
 
 
