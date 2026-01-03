using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Vehicle;

namespace Application.Vehicle.Quiries.procSafetySecurity
{
    public class GetprocSafetySecurityLoadAllVm : IMapFrom<SafetySecurity>
    {
        public System.Guid Safety_SecurityID { get; set; }
        public System.Guid? Vehicle_DispatchID { get; set; }
        public string Location { get; set; }
        public string Reported_By { get; set; }
        public string Location_X { get; set; }
        public string Location_Y { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<SafetySecurity, GetprocSafetySecurityLoadAllVm>();
        }
    }
}
