using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.cTurmsAndCreditvendor.cTurmsAndCreditvendorUpdate.cTurmsAndCreditvendorUpdateCommand
{

	/// @author  Shimels Alem  c_TurmsAndCredit_vendorUpdate stored procedure.


	public class cTurmsAndCreditvendorUpdateCommand : IRequest<IList<CTurmsAndCreditVendor_Id>>
   {
        public long Id { get; set; }
        public string Org_id { get; set; }
        public bool? C_O_D { get; set; }
        public bool? Prepaid { get; set; }
        public bool? DueinNumberofDays { get; set; }
        public bool? DueonDayofnextMonth { get; set; }
        public bool? Dueatendofmonth { get; set; }
        public int? DueontheNextMonth { get; set; }
        public int? NetDueinday { get; set; }
        public int? Discountindays { get; set; }
        public int? DiscountPercent { get; set; }
        public decimal? CreaditLimit { get; set; }
        public long? CreaditStatus { get; set; }
        public string GLSalesAccount { get; set; }
        public string DiscountGLAccount { get; set; }
    }
		
		
		 
}

