using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Bsc;
using XOKA.Domain.Interfaces;

namespace Application.BSC.Commands.StrategicInnitiative.StrategicInnitiativeInsert.StrategicInnitiativeInsertCommand
{ 
	 
      public class StrategicInnitiativeInsertHandler : IRequestHandler<StrategicInnitiativeInsertCommand, IList<Strategic_Innitiative_Innitiative_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public StrategicInnitiativeInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Strategic_Innitiative_Innitiative_ID>> Handle( StrategicInnitiativeInsertCommand request, CancellationToken cancellationToken)
        {
		 string Innitiative_ID = request.Innitiative_ID;
		 Guid? ASPA_ID = request.ASPA_ID;
		 Guid? Type_Of_Innitiative = request.Type_Of_Innitiative;
		 string Innitiative = request.Innitiative;
		 string Description = request.Description;
		 Double? Estimated_Cost_In_Birr = request.Estimated_Cost_In_Birr;
		 Double? Value_In_Per = request.Value_In_Per;
		 string unit = request.Unit;
		 string Expected_Result = request.Expected_Result;
		 string Required_Inputs = request.Required_Inputs;
		 Double? EstimatedBudget = request.EstimatedBudget;
		 string Budget_Account = request.Budget_Account;
		 DateTime? StartDate = request.StartDate;
		 DateTime? EndDate = request.EndDate;
		 string ParentInnitiative_ID = request.ParentInnitiative_ID;
		 bool Is_Active = request.Is_Active;
		 Guid Created_By_User = request.Created_By_User;
		 Double? Acctual = request.Acctual;
		 Double? Variance = request.Variance;
		 Double? Duration_In_Days = request.Duration_In_Days;
		 Int32? Priority = request.Priority;
		 Byte[] Document = request.Document;
		 Guid? Document_Details_ID = request.Document_Details_ID;

		IList<Strategic_Innitiative_Innitiative_ID> result = await _procedureAdabter
                .Execute<Strategic_Innitiative_Innitiative_ID>("[BSC].Strategic_InnitiativeInsert", 
				(nameof(Innitiative_ID), Innitiative_ID),
				(nameof(ASPA_ID), ASPA_ID),
				(nameof(Type_Of_Innitiative), Type_Of_Innitiative),
				(nameof(Innitiative), Innitiative),
				(nameof(Description), Description), 
				(nameof(Estimated_Cost_In_Birr), Estimated_Cost_In_Birr),
				(nameof(Value_In_Per), Value_In_Per),
				(nameof(unit), unit),
				(nameof(Expected_Result), Expected_Result),
				(nameof(Required_Inputs), Required_Inputs),
				(nameof(EstimatedBudget), EstimatedBudget),
				(nameof(Budget_Account), Budget_Account),
				(nameof(StartDate), StartDate),
				(nameof(EndDate), EndDate),
				(nameof(ParentInnitiative_ID), ParentInnitiative_ID),
				(nameof(Is_Active), Is_Active),
				(nameof(Created_By_User), Created_By_User),
				(nameof(Acctual), Acctual),
				(nameof(Variance), Variance),
				(nameof(Duration_In_Days), Duration_In_Days),
				(nameof(Priority), Priority),
				(nameof(Document), Document),
				(nameof(Document_Details_ID), Document_Details_ID));
           
            return result;
        }
    }
}
 
