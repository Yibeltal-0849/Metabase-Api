using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.HRA;

namespace Application.HRA.Quiries.procLeave
{
    public class GetprocLeaveLoadAllVm2 : IMapFrom<Leave>
    {
		public Guid Leave_ID { get; set; }
		public Guid? Lease_Tran_ID { get; set; }
		public Double? Remaining_Leave { get; set; }
		public DateTime? Date_Applied { get; set; }
		public Guid? Leave_Type { get; set; }
		public DateTime? Leave_From_Date { get; set; }
		public DateTime? Leave_End_Date { get; set; }
		public string Substitute { get; set; }
		public string Verified_By { get; set; }
		public string Employee_ID { get; set; }
		public bool? With_Salary { get; set; }
		public bool? Without_Salary { get; set; }
		public Guid? Document_Details_ID { get; set; }
		public void Mapping(Profile profile)
        {
            profile.CreateMap<Leave2, GetprocLeaveLoadAllVm2>();
        }
    }
}
