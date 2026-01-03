using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Commands.proctblConsumptionTransaction.proctblConsumptionTransactionUpdate.proctblConsumptionTransactionUpdateCommand
{

	/// @author  Shimels Alem  proc_tblConsumption_TransactionUpdate stored procedure.


	public class proctblConsumptionTransactionUpdateCommand : IRequest<IList<tblConsumptionTransaction_Tranaction_Id>>
   {
		public string Tranaction_Id { get; set; }
		public DateTime? Start_Date { get; set; }
		public DateTime? End_Date { get; set; }
		public bool? Complited { get; set; }
	}
		
		
		 
}

