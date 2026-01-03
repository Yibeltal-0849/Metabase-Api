using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Queries.proctblResourceProduct
{
    public class GetproctblResourceProductLoadAllVm : IMapFrom<tblResourceProduct>
    {
        public long id { get; set; }
        public long? Resource_Id { get; set; }
        public long? UseOrUsed_For { get; set; }
        public string Remark { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<tblResourceProduct, GetproctblResourceProductLoadAllVm>();
        }
    }
}
