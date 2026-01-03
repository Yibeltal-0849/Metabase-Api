using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Quiries.procC2BPaymentValidationRequest
{
    public class GetC2BPaymentValidationRequestLoadAllVm : IMapFrom<C2BPaymentValidationRequest>
    {
        public string ResultCode { get; set; }
        public string ResultDesc { get; set; }
        public string TransID { get; set; }
        public string BillRefNumber { get; set; }
        public string UtilityName { get; set; }
        public string CustomerName { get; set; }
        public Double Amount { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<C2BPaymentValidationRequest, GetC2BPaymentValidationRequestLoadAllVm>();
        }
    }
}
