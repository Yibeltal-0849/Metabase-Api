using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.BSC.Quiries.StrategicThemes.GetStrategicThemesLoadAll;

namespace Application.BSC.Quiries.StrategicThemes.GetStrategicThemesLoadByPrimaryKeyStrategyNO
{
    /// @author  Shimels Alem Strategic_ThemesLoadByPrimaryKey_Strategy_NO stored procedure.

    public class GetStrategicThemesLoadByPrimaryKeyStrategyNO : IRequest<GetStrategicThemesLoadAllListVm>
    {
        public string Strategy_NO { get; set; }
    }
}
