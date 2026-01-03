


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.cTurmsAndCredit.cTurmsAndCreditInsert.cTurmsAndCreditInsertCommand
{

    /// @author  Shimels Alem  c_TurmsAndCreditInsert stored procedure.


    public class cTurmsAndCreditInsertCommand : IRequest<IList<CTurmsAndCredit_Id>>
    {
        public long? Id { get; set; }
        public string Org_id { get; set; }
        public bool? C_O_D { get; set; }
        public bool? Prepaid { get; set; }
        public bool? Due_in_Number_of_Days { get; set; }
        public bool? Due_on_Day_of_next_Month { get; set; }
        public bool? Due_at_end_of_month { get; set; }
        public int? Due_on_the_Next_Month { get; set; }
        public int? Net_Due_in_day { get; set; }
        public int? Discount_in_days { get; set; }
        public int? Discount_Percent { get; set; }
        public decimal? Creadit_Limit { get; set; }
        public long? Creadit_Status { get; set; }
        public string GL_Sales_Account { get; set; }
        public string Discount_GL_Account { get; set; }
    }
		
		
		 
}
 
 