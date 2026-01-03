using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.dbo;

namespace Application.dbo.Quiries.procProperty_Document
{
    public class GetprocProperty_DocumentLoadAllVm2 : IMapFrom<Property_Document>
    {
        public System.Guid ID { get; set; }
        public string PROPERTY_ID { get; set; }
        public System.Guid? Updated_by { get; set; }
        public System.Guid? Deleted_by { get; set; }
        public string? Description { get; set; }
        public string? Documents { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<Property_Document, GetprocProperty_DocumentLoadAllVm2>();
        }
    }
}
