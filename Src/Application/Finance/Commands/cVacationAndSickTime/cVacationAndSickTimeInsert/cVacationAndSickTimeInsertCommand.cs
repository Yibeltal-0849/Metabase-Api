


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.cVacationAndSickTime.cVacationAndSickTimeInsert.cVacationAndSickTimeInsertCommand
{

    /// @author  Shimels Alem  c_VacationAndSickTimeInsert stored procedure.


    public class cVacationAndSickTimeInsertCommand : IRequest<IList<CVacationAndSickTime_id>>
    {
        public long? id { get; set; }
        public string EmployeBenefitType { get; set; }
        public int? GivenPerYear { get; set; }
        public bool? at_begining_of_calander { get; set; }
        public bool? RemainingTimecarrytoNextYear { get; set; }
        public int? MaximumHoursPeryear { get; set; }
        public string GL_AccountsEmpContribution { get; set; }
        public string OrgId { get; set; }
        public string GL_AccountExp { get; set; }
        public string GL_Account_Liability { get; set; }
    }
		
		
		 
}
 
 