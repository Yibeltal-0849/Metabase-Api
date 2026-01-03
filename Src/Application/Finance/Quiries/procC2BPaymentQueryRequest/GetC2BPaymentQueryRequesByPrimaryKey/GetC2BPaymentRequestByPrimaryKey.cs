using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.procC2BPaymentQueryRequest.GetC2BPaymentQueryRequestLoadAll;

namespace Application.Finance.Quiries.procC2BPaymentQueryRequest.GetC2BPaymentQueryRequesByPrimaryKey
{
    /// @author  Shimels Alem proc_c_Account_CatLoadByPrimaryKey stored procedure.

    public class GetC2BPaymentRequestByPrimaryKey : IRequest<GetC2BPaymentQueryRequestLoadAllListVm>
    {
        public string TransType { get; set; }
        public string TransID { get; set; }
        public string TransTime { get; set; }
        public string BusinessShortCode { get; set; }
        public string BillRefNumber { get; set; }
        public string MSISDN { get; set; }
        

    }
}
