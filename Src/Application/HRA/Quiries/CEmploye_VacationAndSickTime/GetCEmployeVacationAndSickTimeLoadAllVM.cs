using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.HRA;

namespace XOKA.Application.HRA.Quiries.CEmploye_VacationAndSickTime
{
    public class GetCEmployeVacationAndSickTimeLoadAllVM : IMapFrom<Proc_C_Employe_VacationAndSickTime>
    {
        public long? id { get; set; }
        public string Employee_Id { get; set; }
        public bool? UseDefault { get; set; }
        public long? EmplyeeGetHours { get; set; }
        public bool? Receives_At_Begining { get; set; }
        public long? MaxVacationOrSick_Time { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Proc_C_Employe_VacationAndSickTime, GetCEmployeVacationAndSickTimeLoadAllVM>();
        }
    }
}
