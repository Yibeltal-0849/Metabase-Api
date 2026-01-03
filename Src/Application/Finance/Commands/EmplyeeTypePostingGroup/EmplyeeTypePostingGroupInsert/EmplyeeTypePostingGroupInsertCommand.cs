


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.EmplyeeTypePostingGroup.EmplyeeTypePostingGroupInsert.EmplyeeTypePostingGroupInsertCommand
{

    /// @author  Shimels Alem  c_Account_CatInsert stored procedure.


    public class EmplyeeTypePostingGroupInsertCommand : IRequest<IList<Emplyee_Type_Posting_GroupID>>
    {
       public string Code { get; set; }
        public string Description { get; set; }
        public string Gross_Salary_Account { get; set; }
        public string Net_Salary_Account { get; set; }
        public string Inc_Tax_Account { get; set; }
        public string Pen_Tax_Account { get; set; }
        public string Com_Pen_Cont_Account { get; set; }
        public string Over_Time_Account { get; set; }
        public string Allwance_Account { get; set; }
        public string CostSharing { get; set; }
        public string Pen_Tax_Cost { get; set; }
        public string Other_Account { get; set; }
        public Nullable<System.Guid> Branch_ID { get; set; }
    }
		
		
		 
	}
 
 