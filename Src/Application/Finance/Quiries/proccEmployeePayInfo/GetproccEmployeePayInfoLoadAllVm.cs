using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Quiries.proccEmployeePayInfo
{
    public class GetproccEmployeePayInfoLoadAllVm : IMapFrom<CEmployeePayInfo>
    {
        public long id { get; set; }
        public string orgcode { get; set; }
        public string Employee_Id { get; set; }
        public string Pay_Type { get; set; }
        public bool? UseDefault { get; set; }
        public string Pay_Frequency { get; set; }
        public string GL_Account { get; set; }
        public decimal? Salary_Hour_Pay { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<CEmployeePayInfo, GetproccEmployeePayInfoLoadAllVm>();
        }
    }
}
