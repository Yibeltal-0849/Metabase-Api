using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Quiries.procCash_Flow_Setting
{
    public class GetprocCash_Flow_SettingLoadAllVm : IMapFrom<Cash_Flow_Setting>
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string GL_Account { get; set; }
        public string Formula { get; set; }
        public bool? Is_Active { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<Cash_Flow_Setting, GetprocCash_Flow_SettingLoadAllVm>();
        }
    }
}
