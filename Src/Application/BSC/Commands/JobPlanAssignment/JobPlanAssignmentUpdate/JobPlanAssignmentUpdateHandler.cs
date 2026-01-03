

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Bsc;
using XOKA.Domain.Interfaces;



namespace Application.BSC.Commands.JobPlanAssignment.JobPlanAssignmentUpdate.JobPlanAssignmentUpdateCommand
{

    /// @author  Shimels Alem  Job_Plan_AssignmentUpdate stored procedure.


    public class JobPlanAssignmentUpdateHandler : IRequestHandler<JobPlanAssignmentUpdateCommand, IList<JobPlanAssignment_JobPA_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public JobPlanAssignmentUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<JobPlanAssignment_JobPA_ID>> Handle( JobPlanAssignmentUpdateCommand request, CancellationToken cancellationToken)
        {

            System.Guid? JobPA_ID = request.JobPA_ID;
            string Operational_Task_ID = request.Operational_Task_ID;
            System.Guid? Assigned_Body = request.Assigned_Body;
            System.Guid? Responsible_Role = request.Responsible_Role;
            string Responsible_User_ID = request.Responsible_User_ID;
            bool? Is_Active = request.Is_Active;
            Byte[] Log = request.Log;
            string ApplicationCode = request.ApplicationCode;
            string Application_NO = request.Application_NO;
            string Doc_No = request.Doc_No;
            System.Guid? Assigned_By = request.Assigned_By;

            IList<JobPlanAssignment_JobPA_ID> result = await _procedureAdabter
                .Execute<JobPlanAssignment_JobPA_ID>("[BSC].Job_Plan_AssignmentUpdate",
                     (nameof(JobPA_ID), JobPA_ID),
                     (nameof(Operational_Task_ID), Operational_Task_ID),
                     (nameof(Assigned_Body), Assigned_Body),
                     (nameof(Responsible_Role), Responsible_Role),
                     (nameof(Responsible_User_ID), Responsible_User_ID),
                     (nameof(Is_Active), Is_Active),
                     (nameof(Log), Log),
                     (nameof(ApplicationCode), ApplicationCode),
                     (nameof(Application_NO), Application_NO),
                     (nameof(Doc_No), Doc_No),
                     (nameof(Assigned_By), Assigned_By)
                    );

            return result;
        }
    }
}
 