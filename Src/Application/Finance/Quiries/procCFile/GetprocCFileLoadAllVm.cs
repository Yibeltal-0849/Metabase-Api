using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Quiries.procCFile
{
    public class GetprocCFileLoadAllVm : IMapFrom<CFile>
    {
        public System.Guid C_File_ID { get; set; }
        public string AD_Table_ID { get; set; }
        public string AD_Record_ID { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<CFile, GetprocCFileLoadAllVm>();
        }
    }
}
