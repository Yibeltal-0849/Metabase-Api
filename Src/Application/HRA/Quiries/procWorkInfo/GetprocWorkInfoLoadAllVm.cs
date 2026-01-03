using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.HRA;

namespace Application.HRA.Quiries.procWorkInfo
{
    public class GetprocWorkInfoLoadAllVm : IMapFrom<WorkInfo>
    {
        public System.Guid WorkInfo_ID { get; set; }
        public string Employee_ID { get; set; }
        public string Provision { get; set; }
        public string E_Mail { get; set; }
        public string Work_Phone_Number { get; set; }
        public string Cell_Phone_Number { get; set; }
        public string Job_Title { get; set; }
        public System.Guid Employement_Request { get; set; }
        public bool? IS_Active { get; set; }
        public string Employee_Contract_NO { get; set; }
        public System.Guid Department_code { get; set; }
        public System.Guid Structure_ID { get; set; }
        public System.Guid Emp_Transfer_Type { get; set; }
        public System.DateTime Start_Date { get; set; }
        public System.DateTime End_Date { get; set; }
        public System.Guid Document_Detail_Code { get; set; }
        public System.Guid? job_position { get; set; }
        public System.Guid? job_grade { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<WorkInfo, GetprocWorkInfoLoadAllVm>();
        }
    }
}
