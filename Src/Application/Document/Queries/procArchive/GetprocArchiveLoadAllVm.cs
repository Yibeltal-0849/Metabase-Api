using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Document;

namespace Application.Document.Quiries.procArchive
{
    public class GetprocArchiveLoadAllVm : IMapFrom<Archive>
    {
        public string FolderNO { get; set; }
        public string Name { get; set; }
        public string Archive_Type { get; set; }
        public string Shelf_Raw { get; set; }
        public string Shelf_Column { get; set; }
        public System.Guid Letter_ID { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<Archive, GetprocArchiveLoadAllVm>();
        }
    }
}
