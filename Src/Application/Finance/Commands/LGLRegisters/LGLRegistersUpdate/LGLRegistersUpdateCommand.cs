using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.LGLRegisters.LGLRegistersUpdate.LGLRegistersUpdateCommand
{

	/// @author  Shimels Alem  L_G_L_RegistersUpdate stored procedure.


	public class LGLRegistersUpdateCommand : IRequest<IList<LGLRegisters_Branch_ID>>
   {
		public System.Guid Branch_ID { get; set; }
		public System.DateTime Period { get; set; }
		public System.DateTime posting_Date { get; set; }
		public string No { get; set; }
		public System.DateTime? Creation_Date { get; set; }
		public string User_ID { get; set; }
		public string Source_Code { get; set; }
		public string Journal_Batch_Name { get; set; }
		public string From_Entry_No { get; set; }
		public string To_Entry_No { get; set; }
		public string From_VAT_Entry_No { get; set; }
		public string To_VAT_Entry_No { get; set; }
	}
		
		
		 
}

