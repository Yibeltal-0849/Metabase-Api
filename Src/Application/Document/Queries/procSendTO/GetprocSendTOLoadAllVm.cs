using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Document;

namespace Application.Document.Quiries.procSendTO
{
    public class GetprocSendTOLoadAllVm : IMapFrom<SendTO>
    {
        public System.Guid Email_ID { get; set; }
        public System.Guid? Letter_ID { get; set; }
        public System.Guid? Org_ID { get; set; }
        public System.Guid? Department_ID { get; set; }
        public System.Guid? Stracture_Role_ID { get; set; }
        public bool? Cc { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<SendTO, GetprocSendTOLoadAllVm>();
        }
    }
}
