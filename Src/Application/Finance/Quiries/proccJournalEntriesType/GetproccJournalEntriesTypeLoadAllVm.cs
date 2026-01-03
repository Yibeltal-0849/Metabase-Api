using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Quiries.proccJournalEntriesType
{
    public class GetproccJournalEntriesTypeLoadAllVm : IMapFrom<CJournalEntriesType>
    {


        public string Type { get; set; }
        public string Form_Link { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<CJournalEntriesType, GetproccJournalEntriesTypeLoadAllVm>();
        }
    }
}
