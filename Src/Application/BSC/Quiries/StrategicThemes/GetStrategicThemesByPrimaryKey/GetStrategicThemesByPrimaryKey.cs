using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.BSC.Quiries.StrategicThemes.GetStrategicThemesLoadAll;

namespace Application.BSC.Quiries.StrategicThemes.GetStrategicThemesByPrimaryKey
{
     /// @author  Shimels Alem Strategic_ThemesLoadByPrimaryKey stored procedure.

    public class GetStrategicThemesByPrimaryKey : IRequest<GetStrategicThemesLoadAllListVm>
    {
        public string Strategic_ThemeID { get; set; }
    }
}
