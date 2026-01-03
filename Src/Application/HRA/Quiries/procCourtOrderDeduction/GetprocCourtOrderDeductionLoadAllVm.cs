using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.HRA;

namespace Application.HRA.Quiries.procCourtOrderDeduction
{
    public class GetprocCourtOrderDeductionLoadAllVm : IMapFrom<CourtOrderDeduction>
    {
        public System.Guid Court_Order_ID { get; set; }
        public string Employee_ID { get; set; }
        public string Sub_Account_No { get; set; }
        public string Payee_Name { get; set; }
        public double? Amount { get; set; }
        public byte[] Court_Letter { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<CourtOrderDeduction, GetprocCourtOrderDeductionLoadAllVm>();
        }
    }
}
