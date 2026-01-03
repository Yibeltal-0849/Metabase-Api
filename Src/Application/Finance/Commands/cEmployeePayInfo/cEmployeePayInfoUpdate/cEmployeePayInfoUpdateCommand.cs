using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.cEmployeePayInfo.cEmployeePayInfoUpdate.cEmployeePayInfoUpdateCommand
{

    /// @author  Shimels Alem  c_EmployeePayInfoUpdate stored procedure.


    public class cEmployeePayInfoUpdateCommand : IRequest<IList<CEmployeePayInfo_id>>
    {
        public long id { get; set; }
        public string orgcode { get; set; }
        public string Employee_Id { get; set; }
        public string Pay_Type { get; set; }
        public bool? UseDefault { get; set; }
        public string Pay_Frequency { get; set; }
        public string GL_Account { get; set; }
        public decimal? Salary_Hour_Pay { get; set; }
    }
		
		
		 
	}

