using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Budget;

namespace Application.Document.Quiries.procArchiveType
{
    public class GetprocArchiveTypeLoadAllVm : IMapFrom<Archive_Type>
    {
        public string Name_Type { get; set; }
        public string Description { get; set; }
        public string Room { get; set; }
        public System.Guid? Site { get; set; }
        public string Block_Floor { get; set; }
        public string Shelf_NO { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<Archive_Type, GetprocArchiveTypeLoadAllVm>();
        }
    }
}
