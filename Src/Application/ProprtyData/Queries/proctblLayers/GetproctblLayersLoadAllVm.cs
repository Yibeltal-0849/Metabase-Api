using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Queries.proctblLayers
{
    public class GetproctblLayersLoadAllVm : IMapFrom<tblLayers>
    {
		public long id { get; set; }
		public string Name { get; set; }
		public string Back_Color { get; set; }
		public string Fill_Color { get; set; }
		public string Line_Color { get; set; }
		public string Outline_Color { get; set; }
		public bool EnableOutline { get; set; }
		public string Label_Column { get; set; }
		public string Label_ForeColor { get; set; }
		public string GIS_Column { get; set; }
		public string OID_Column { get; set; }
		public bool? Point { get; set; }
		public void Mapping(Profile profile)
        {
            profile.CreateMap<tblLayers, GetproctblLayersLoadAllVm>();
        }
    }
}
