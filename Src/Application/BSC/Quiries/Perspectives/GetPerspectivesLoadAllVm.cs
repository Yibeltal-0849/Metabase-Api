using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Bsc;

namespace Application.BSC.Quiries.Perspectives
{
    public class GetPerspectivesLoadAllVm : IMapFrom<_Perspectives>
    {
        public string Perspective_ID { get; set; }
        public string Perspective_Name { get; set; }
        public bool? ISactive { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<_Perspectives, GetPerspectivesLoadAllVm>();
        }
    }
}
