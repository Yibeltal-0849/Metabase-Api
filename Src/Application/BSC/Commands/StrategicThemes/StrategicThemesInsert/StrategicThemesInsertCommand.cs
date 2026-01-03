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

    ///   @author  Shimels Alem Strategic_ThemesInsert stored procedure.

    public class StrategicThemesInsertCommand : IRequest<IList<Strategic_Themes_Strategic_ThemeID>>
    {
        public string Strategic_ThemeID { get; set; }
        public string Strategy_NO { get; set; }
        public string Strategic_Theme { get; set; }
        public string Strategic_Result { get; set; }
        public string Strategic_Theme_Description { get; set; }
        public string Log { get; set; }
    }
		
		 
	}
 
 
