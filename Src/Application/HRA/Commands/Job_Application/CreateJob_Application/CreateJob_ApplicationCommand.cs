using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.HRA;

namespace XOKA.Application.HRA.Commands.Job_Application.CreateJob_Application
{
    /// @author  Shimels Alem  CreateCJob_Application stored procedure.
    
    public class CreateJob_ApplicationCommand : IRequest<IList<JobApplication_Job_AppID>>
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
