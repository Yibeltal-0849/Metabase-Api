using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.HRA;

namespace Application.HRA.Quiries.procJobPositions
{
    public class GetprocJobPositionsLoadAllVm : IMapFrom<JobPositions>
    {
        public Guid Pos_ID { get; set; }
		public string PositionName { get; set; }
		public Guid? Department_code { get; set; }
        public string? department_name { get; set; }
        //public string Grade { get; set; }
        //public string? Leave_type { get; set; }
        public string? JobDescription { get; set; }
        public bool? IS_Attendance_Controlled { get; set; }
		public string Parent { get; set; }
        public string? ParentName { get; set; }
        public bool? Is_Active { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<JobPositions, GetprocJobPositionsLoadAllVm>();
        }
    }
}
