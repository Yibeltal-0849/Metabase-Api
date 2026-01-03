using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Quiries.procJBankReconTransaction
{
    public class GetprocJBankReconTransactionLoadAllVm : IMapFrom<JBankReconTransaction>
    {
        public System.Guid Trans_ID { get; set; }
        public System.DateTime? Statement_Date { get; set; }
	    public string Statement_No { get; set; }
	    public decimal Balance_Last_Statement { get; set; }
        public decimal Statement_Ending_Balance { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<JBankReconTransaction, GetprocJBankReconTransactionLoadAllVm>();
        }
    }
}
