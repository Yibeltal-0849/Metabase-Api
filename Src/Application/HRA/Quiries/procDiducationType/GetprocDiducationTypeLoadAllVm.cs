using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.HRA;

namespace Application.HRA.Quiries.procDiducationType
{
    public class GetprocDiducationTypeLoadAllVm : IMapFrom<DiducationType>
    {
		public System.Guid? DiductionCode { get; set; }
        public string Name { get; set; }
        public int? Priority { get; set; }
        public bool? IS_Forever { get; set; }
        public bool? Is_Before_Tax { get; set; }
        public string? GL_Account { get; set; }
        public bool? Is_Active { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<DiducationType, GetprocDiducationTypeLoadAllVm>();
        }
    }
}
