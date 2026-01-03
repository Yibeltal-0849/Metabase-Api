using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.cVacationAndSickTime.cVacationAndSickTimeUpdate.cVacationAndSickTimeUpdateCommand
{

	/// @author  Shimels Alem  c_VacationAndSickTimeUpdate stored procedure.


	public class cVacationAndSickTimeUpdateCommand : IRequest<IList<CVacationAndSickTime_id>>
   {
        public long id { get; set; }
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

