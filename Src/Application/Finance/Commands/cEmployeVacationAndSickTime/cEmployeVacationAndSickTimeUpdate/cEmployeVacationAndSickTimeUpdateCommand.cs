using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.cEmployeVacationAndSickTime.cEmployeVacationAndSickTimeUpdate.cEmployeVacationAndSickTimeUpdateCommand
{

    /// @author  Shimels Alem  c_Employe_VacationAndSickTimeUpdate stored procedure.


    public class cEmployeVacationAndSickTimeUpdateCommand : IRequest<IList<CEmployeVacationAndSickTime_id>>
   {
        public long id { get; set; }
        public string Employee_Id { get; set; }
        public bool? UseDefault { get; set; }
        public long? EmplyeeGetHours { get; set; }
        public bool? Receives_at_Begining { get; set; }
        public long? MaxVacationOrSick_Time { get; set; }
    }
		
		
		 
	}

