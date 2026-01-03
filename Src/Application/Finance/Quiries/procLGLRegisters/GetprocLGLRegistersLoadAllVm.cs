using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Quiries.procLGLRegisters
{
    public class GetprocLGLRegistersLoadAllVm : IMapFrom<LGLRegisters>
    {
        public System.Guid Branch_ID { get; set; }
        public System.DateTime Period { get; set; }
        public System.DateTime posting_Date { get; set; }
        public string No { get; set; }
        public System.DateTime Creation_Date { get; set; }
        public string User_ID { get; set; }
        public string Source_Code { get; set; }
        public string Journal_Batch_Name { get; set; }
        public string From_Entry_No { get; set; }
        public string To_Entry_No { get; set; }
        public string From_VAT_Entry_No { get; set; }
        public string To_VAT_Entry_No { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<LGLRegisters, GetprocLGLRegistersLoadAllVm>();
        }
    }
}
