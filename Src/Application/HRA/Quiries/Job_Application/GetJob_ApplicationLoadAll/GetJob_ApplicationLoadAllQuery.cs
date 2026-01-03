using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace XOKA.Application.HRA.Quiries.Job_Application.GetJob_ApplicationLoadAll
{
    public class GetJob_ApplicationLoadAllQuery : IRequest<GetJob_ApplicationLoadAllListVm>
    {
        public string Job_AppID { get; set; }
        public Guid? application_code { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public DateTime? Application_Date { get; set; }
        public DateTime? Birth_Date { get; set; }
        public string Nationality { get; set; }
        public string Address { get; set; }
        public string Phone_Number { get; set; }
        public string E_Mail { get; set; }
        public Guid? Application_Position { get; set; }
        public bool? Submited { get; set; }
        public Guid? Job_Application_Status { get; set; }
        public byte[]? CV { get; set; }
        public bool Are_you_currently_employed_here { get; set; }
        public string Education_type_level { get; set; }
        public string Payroll_ID { get; set; }
        public string Work_experience { get; set; }
        public float Cumulative_GPA { get; set; }
    }
}
