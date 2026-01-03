using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Quiries.proctblProjects
{
    public class GetproctblProjectsLoadAllVm : IMapFrom<tblProjects>
    {
		public long? id { get; set; }
		public long? Companys_Id { get; set; }
		public long? Status { get; set; }
		public string name { get; set; }
		public string Areas { get; set; }
		public System.DateTime? Start_Date { get; set; }
		public System.DateTime? End_Date { get; set; }
		public string Objective { get; set; }
		public string Description { get; set; }
		public string Results { get; set; }
		public void Mapping(Profile profile)
        {
            profile.CreateMap<tblProjects, GetproctblProjectsLoadAllVm>();
        }
    }
}
