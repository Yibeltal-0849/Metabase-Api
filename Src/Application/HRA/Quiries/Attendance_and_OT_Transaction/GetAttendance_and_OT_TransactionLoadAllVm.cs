using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.HRA;

namespace XOKA.Application.HRA.Quiries.Attendance_and_OT_Transaction
{
    public class GetAttendance_and_OT_TransactionLoadAllVm : IMapFrom<AttendanceAndOtTransaction>
    {
        public System.Guid Att_OT_Trans_Id { get; set; }
        public System.Guid? Application_Code { get; set; }
        public string Application_No { get; set; }
        public string Period { get; set; }
        public string Month_Name { get; set; }
        public System.DateTime? Start_Date { get; set; }
        public System.DateTime? End_Date { get; set; }
        public System.Guid? organization_code { get; set; }
        public System.Guid? DIV { get; set; }
        public System.DateTime? TransactionDate { get; set; }
        public string Log { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<AttendanceAndOtTransaction, GetAttendance_and_OT_TransactionLoadAllVm>();
        }
    }
}
