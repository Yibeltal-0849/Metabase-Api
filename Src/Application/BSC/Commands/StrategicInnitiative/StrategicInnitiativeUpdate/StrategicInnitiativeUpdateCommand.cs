using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Bsc;
using XOKA.Domain.Interfaces;

namespace Application.BSC.Commands.StrategicInnitiative.StrategicInnitiativeUpdate.StrategicInnitiativeUpdateCommand
{

    ///   @author  Shimels Alem Strategic_InnitiativeUpdate stored procedure.

    public class StrategicInnitiativeUpdateCommand : IRequest<IList<Strategic_Innitiative_Innitiative_ID>>
    {
		public string Innitiative_ID { get; set; }
		public Guid? ASPA_ID { get; set; }
		public Guid? Type_Of_Innitiative { get; set; }
		public string Innitiative { get; set; }
		public string Description { get; set; }
		public Double? Estimated_Cost_In_Birr { get; set; }
		public Double? Value_In_Per { get; set; }
		public string Unit { get; set; }
		public string Expected_Result { get; set; }
		public string Required_Inputs { get; set; }
		public Double? EstimatedBudget { get; set; }
		public string Budget_Account { get; set; }
		public DateTime? StartDate { get; set; }
		public DateTime? EndDate { get; set; }
		public string ParentInnitiative_ID { get; set; }
		public bool Is_Active { get; set; }
		public Guid Created_By_User { get; set; }
		public Double? Acctual { get; set; }
		public Double? Variance { get; set; }
		public Double? Duration_In_Days { get; set; }
		public Int32? Priority { get; set; }
		public Byte[] Document { get; set; }
		public Guid? Document_Details_ID { get; set; }

	}
		
		 
	}
 
 
