using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.procC2BPaymentValidationRequest.GetC2BPaymentValidationRequestLoadAll;

namespace Application.Finance.Quiries.procC2BPaymentValidationRequest.GetC2BPaymentValidationRequestLoadAll
{
    /// @author  Shimels Alem proc_c_Account_CatLoadByPrimaryKey stored procedure.

    public class GetPaymentValidationRequestByPrimaryKey : IRequest<GetC2BPaymentValidationRequestLoadAllListVm>
    {
        public string TransType { get; set; }
        public string TransID { get; set; }
        public string TransTime { get; set; }
        public string TransAmount { get; set; }
        public string BusinessShortCode { get; set; }
        public string BillRefNumber { get; set; }
        public string InvoiceNumber { get; set; }
        public string MSISDN { get; set; }
        public string KYCInfo { get; set; }
    
    }
}
