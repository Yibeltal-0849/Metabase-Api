using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Queries.proctblDocumentType
{
    public class GetproctblDocumentTypeLoadAllVm : IMapFrom<tblDocumentType>
    {
        public long id { get; set; }
        public string Name { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<tblDocumentType, GetproctblDocumentTypeLoadAllVm>();
        }
    }
}
