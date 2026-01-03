using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.HRA;

namespace XOKA.Application.HRA.Quiries.Employee_Doucment
{
    public class GetEmployeeDoucmentLoadAllVm : IMapFrom<EmployeeDoucment>
    {
        public System.Guid ID { get; set; }
        public Guid Employee_Id { get; set; }
        public string Document_Name { get; set; }

        public byte[] Document_upload { get; set; }
        public string DocType { get; set; }
        public bool? IsDeleted { get; set; }
        public string? Penshion { get; set; }
        public System.DateTime? Uploaded_Date
        {
            get; set;
        }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<EmployeeDoucment, GetEmployeeDoucmentLoadAllVm>();
        }
    }
}
