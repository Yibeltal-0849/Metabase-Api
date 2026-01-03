using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Quiries.proccEmployeVacationAndSickTime
{
    public class GetproccEmployeVacationAndSickTimeLoadAllVm : IMapFrom<CEmployeVacationAndSickTime>
    {
        public long id { get; set; }
        public string Employee_Id { get; set; }
        public bool? UseDefault { get; set; }
        public long? EmplyeeGetHours { get; set; }
        public bool? Receives_at_Begining { get; set; }
        public long? MaxVacationOrSick_Time { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<CEmployeVacationAndSickTime, GetproccEmployeVacationAndSickTimeLoadAllVm>();
        }
    }
}
