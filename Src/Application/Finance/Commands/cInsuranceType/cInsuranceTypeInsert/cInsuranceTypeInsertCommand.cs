


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.cInsuranceType.cInsuranceTypeInsert.cInsuranceTypeInsertCommand
{

	/// @author  Shimels Alem  c_InsuranceTypeInsert stored procedure.


	public class cInsuranceTypeInsertCommand : IRequest<IList<CInsuranceType_Name>>
    {
		public string Name { get; set; }
		public bool? Enable { get; set; }
	}
		
		
		 
	}
 
 