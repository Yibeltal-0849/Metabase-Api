using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.HRA;

namespace XOKA.Application.HRA.Quiries.CFile
{
    public class GetCFileLoadAllVm : IMapFrom<Proc_C_File>
    {
        public Guid C_File_ID { get; set; }
        public string AD_Table_ID { get; set; }
        public string AD_Record_ID { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Proc_C_File, GetCFileLoadAllVm>();
        }
    }
}
