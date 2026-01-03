using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Bsc;
using XOKA.Domain.Interfaces;

namespace Application.BSC.Commands.KeyPerformanceIndicators.KeyPerformanceIndicatorsInsert.KeyPerformanceIndicatorsInsertCommand
{

	///   @author  Shimels Alem Key_Performance_IndicatorsInsert stored procedure.

	public class KeyPerformanceIndicatorsInsertCommand : IRequest<IList<Key_Performance_Indicators_KPI_ID>>
    {
		public Guid KPI_ID { get; set; }
		public string Performance_Indicator { get; set; }
		public string Description { get; set; }
		public string Perspective_ID { get; set; }
		public bool? Update_Interval_Weekly { get; set; }
		public bool? Update_Interval_Monthly { get; set; }
		public bool? Update_Interval_6Monthly { get; set; }
		public string Group_Function { get; set; }
		public string Unit { get; set; }
		public bool? IS_Quantitative { get; set; }
		public bool? Is_Composite { get; set; }
	}
		
		 
	}
 
 
