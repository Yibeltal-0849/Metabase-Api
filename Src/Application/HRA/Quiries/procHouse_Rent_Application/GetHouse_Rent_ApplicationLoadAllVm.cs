using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.HRA;

namespace XOKA.Application.HRA.Quiries.procHouse_Rent_Application
{
    public class GetHouse_Rent_ApplicationLoadAllVm : IMapFrom<House_Rent_Application>
    {
        public System.Guid Rent_App_ID { get; set; }
        public System.Guid? Customer_Code { get; set; }
        public System.Guid Postion { get; set; }
        public System.Guid? Application_Date { get; set; }
        public bool? Is_Approved { get; set; }
        public Int64 Queue_number { get; set; }
        public string Orgnization_Name_Eng { get; set; }
        public string Orgnization_Name_Am { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<House_Rent_Application, GetHouse_Rent_ApplicationLoadAllVm>();
        }
    }
}
