using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Bsc;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.BSC.Commands.AnnualStrategicPlanAssignment.CreateAnnualStrategicPlanAssignment
{
    public class CreateAnnualStrategicPlanAssignmentHandler : IRequestHandler<CreateAnnualStrategicPlanAssignmentCommand, IList<Proc_Annual_Strategic_Plan_Assignment_ASPA_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public CreateAnnualStrategicPlanAssignmentHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Proc_Annual_Strategic_Plan_Assignment_ASPA_ID>> Handle(CreateAnnualStrategicPlanAssignmentCommand request, CancellationToken cancellationToken)
        {
            System.Guid? ASPA_ID = request.ASPA_ID;
            string ASGD_ID = request.ASGD_ID;
            System.Guid? Assigned_Body = request.Assigned_Body;
            System.Guid? Responsible_Role = request.Responsible_Role;
            bool? Is_Active = request.Is_Active;
            Byte[] Log = request.Log;
            System.Guid ApplicationCode = request.ApplicationCode;
            string Application_NO = request.Application_NO;
            string Doc_No = request.Doc_No;
            System.Guid? Assigned_By = request.Assigned_By;
            IList<Proc_Annual_Strategic_Plan_Assignment_ASPA_ID> result = await _procedureAdabter
                .Execute<Proc_Annual_Strategic_Plan_Assignment_ASPA_ID>("[BSC].[proc_Annual_Strategic_Plan_AssignmentInsert]", (nameof(ASPA_ID), ASPA_ID), (nameof(ASGD_ID), ASGD_ID),
                (nameof(Assigned_Body), Assigned_Body), (nameof(Responsible_Role), Responsible_Role), (nameof(Is_Active), Is_Active),
                (nameof(Log), Log), (nameof(ApplicationCode), ApplicationCode), (nameof(Application_NO), Application_NO),
                (nameof(Doc_No), Doc_No), (nameof(Assigned_By), Assigned_By));

            return result;
        }
    }
}