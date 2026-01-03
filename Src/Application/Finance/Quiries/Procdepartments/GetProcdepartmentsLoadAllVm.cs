using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Quiries.Procdepartments
{
    public class GetProcdepartmentsLoadAllVm : IMapFrom<Proc_departments>
    {
        public System.Guid department_Code { get; set; }
        public string department_Name { get; set; }
        public string Code { get; set; }
        public System.Guid departments_Department_Code { get; set; }
        public System.Guid organizations_Organization_Code { get; set; }
        public bool is_active { get; set; }


        public void Mapping(Profile profile)
        {
            profile.CreateMap<Proc_departments, GetProcdepartmentsLoadAllVm>();
        }
    }
}
