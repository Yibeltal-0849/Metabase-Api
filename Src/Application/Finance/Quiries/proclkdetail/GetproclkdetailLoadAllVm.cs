using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Quiries.proclkdetail
{
    public class GetproclkdetailLoadAllVm : IMapFrom<lkdetail>
    {

        public System.Guid lkdetail_Code { get; set; }
        public System.Guid lkmaster_Master_Code { get; set; }
        public string english_Description { get; set; }
        public string amharic_Description { get; set; }
        public string tigrigna_Description { get; set; }
        public string oromiffa_Description { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<lkdetail, GetproclkdetailLoadAllVm>();
        }
    }
}
