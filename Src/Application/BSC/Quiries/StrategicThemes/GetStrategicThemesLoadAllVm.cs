using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Bsc;

namespace Application.BSC.Quiries.StrategicThemes
{
    public class GetStrategicThemesLoadAllVm : IMapFrom<Strategic_Themes>
    {
        public string Strategic_ThemeID { get; set; }
        public string Strategy_NO { get; set; }
        public string Strategic_Theme { get; set; }
        public string Strategic_Result { get; set; }
        public string Strategic_Theme_Description { get; set; }
        public string Log { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Strategic_Themes, GetStrategicThemesLoadAllVm>();
        }
    }
}
