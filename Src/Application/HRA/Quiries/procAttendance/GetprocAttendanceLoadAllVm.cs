using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.HRA;

namespace Application.HRA.Quiries.procAttendance
{
    public class GetprocAttendanceLoadAllVm : IMapFrom<Attendance>
    {
        public Guid Attendance_ID { get; set; }
        public Guid? Att_OT_Trans_Id { get; set; }
        public DateTime? Date { get; set; }
        public string Employee_ID { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<Attendance, GetprocAttendanceLoadAllVm>();
        }
    }
}
