using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Bsc;
using XOKA.Domain.Interfaces;


namespace XOKA.Application.BSC.Commands.AnnualStrategicGoals.UpdateAnnualStrategicGoals
{
    public class UpdateAnnualStrategicGoalsHandler : IRequestHandler<UpdateAnnualStrategicGoalsCommand, IList<Proc_Annual_Strategic_Goals_Annual_Strategic_GoalID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public UpdateAnnualStrategicGoalsHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }
        public async Task<IList<Proc_Annual_Strategic_Goals_Annual_Strategic_GoalID>> Handle(UpdateAnnualStrategicGoalsCommand request, CancellationToken cancellationToken)
        {
            string Annual_Strategic_GoalID = request.Annual_Strategic_GoalID;
            string Strategic_ThemeID = request.Strategic_ThemeID;
            DateTime? Created_Date = request.Created_Date;
            int? Year = request.Year;
            double? Result_In_Per = request.Result_In_Per;
            System.Guid?ApplicationCode = request.ApplicationCode;
            string Application_NO = request.Application_NO;
            string DocNo = request.DocNo;
            string Log = request.Log;
            bool? isActive = request.IsActive;
            IList<Proc_Annual_Strategic_Goals_Annual_Strategic_GoalID> result = await _procedureAdabter
                .Execute<Proc_Annual_Strategic_Goals_Annual_Strategic_GoalID>("[BSC].[Annual_Strategic_GoalsUpdate]", (nameof(Annual_Strategic_GoalID), Annual_Strategic_GoalID), (nameof(Strategic_ThemeID), Strategic_ThemeID),
                (nameof(Created_Date), Created_Date), (nameof(Year), Year), (nameof(Result_In_Per), Result_In_Per),
                (nameof(ApplicationCode), ApplicationCode), (nameof(Application_NO), Application_NO), (nameof(DocNo), DocNo),
                (nameof(Log), Log), (nameof(isActive), isActive));

            return result;
        }
    }
}
