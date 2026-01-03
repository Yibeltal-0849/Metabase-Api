


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Bsc;

namespace Application.BSC.Commands.procBSCValues.procBSCValuesInsert.procBSCValuesInsertCommand
{

	/// @author  Shimels Alem  proc_BSC_ValuesInsert stored procedure.


	public class procBSCValuesInsertCommand : IRequest<IList<BSCValues_BSCValueID>>
    {
		public System.Guid BSC_Value_ID { get; set; }
		public System.Guid? BSC_Tran_ID { get; set; }
		public System.Guid KPIMapping_ID { get; set; }
		public System.Guid KPI_ID { get; set; }
		public string Performance_Indicator { get; set; }
		public string Period { get; set; }
		public System.DateTime Start_Date { get; set; }
		public System.DateTime End_Date { get; set; }
		public string Unit { get; set; }
		public System.Double? Value { get; set; }
		public string Remark { get; set; }
		public string User_Name { get; set; }
		public System.Guid? User_ID { get; set; }
		public System.DateTime? Created_Date { get; set; }
		public System.DateTime? Update_Date { get; set; }
	}
		
		
		 
}
 
 