using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.HRA;

namespace Application.HRA.Quiries.Training
{
    public class GetTrainingLoadAllVm : IMapFrom<_Training>
    {
        public string Training_ID { get; set; }
        public string Training_Name { get; set; }
        public int? Training_Hour { get; set; }
        public string Description { get; set; }
        public double? Pass_Point { get; set; }
        public bool? Is_Active { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<_Training, GetTrainingLoadAllVm>();
        }
    }
}
