


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.cInsurancePlan.cInsurancePlanInsert.cInsurancePlanInsertCommand
{

	/// @author  Shimels Alem  c_InsurancePlanInsert stored procedure.


	public class cInsurancePlanInsertCommand : IRequest<IList<CInsurancePlan_id>>
    {
        public long? id { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public bool? IsEmploye_Pay { get; set; }
        public bool? IsCompany_Pay { get; set; }
        public long? IsBothPay { get; set; }
        public string PayPercheckper { get; set; }
        public string GL_AccountsEmpContribution { get; set; }
        public string OrgId { get; set; }
        public string GL_AccountExp { get; set; }
        public string GL_Account_Liability { get; set; }
    }
		
		
		 
	}
 
 