using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.HRA;

namespace XOKA.Application.HRA.Quiries.CEmployee_Pay_Info
{
    public class GetCEmployeePayInfoLoadAllVm : IMapFrom<Proc_c_EmployeePayInfo>
    {
        public long id { get; set; }
        public string orgcode { get; set; }
        public string Employee_Id { get; set; }
        public string Pay_Type { get; set; }
        public bool? UseDefault { get; set; }
        public string Pay_Frequency { get; set; }
        public string GL_Account { get; set; }
        public decimal Salary_Hour_Pay { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Proc_c_EmployeePayInfo, GetCEmployeePayInfoLoadAllVm>();
        }
    }
}
