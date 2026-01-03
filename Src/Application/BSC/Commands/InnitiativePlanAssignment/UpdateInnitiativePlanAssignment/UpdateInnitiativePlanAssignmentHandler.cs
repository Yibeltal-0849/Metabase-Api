using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Bsc;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.BSC.Commands.InnitiativePlanAssignment.UpdateInnitiativePlanAssignment
{
    public class UpdateInnitiativePlanAssignmentHandler : IRequestHandler<UpdateInnitiativePlanAssignmentCommand, IList<Innitiative_Plan_Assignment_IPA_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public UpdateInnitiativePlanAssignmentHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Innitiative_Plan_Assignment_IPA_ID>> Handle(UpdateInnitiativePlanAssignmentCommand request, CancellationToken cancellationToken)
        {

            Guid IPA_ID = request.IPA_ID;
            string Innitiative_ID = request.Innitiative_ID;
            Guid? Assigned_Body = request.Assigned_Body;
            Guid? Responsible_Role = request.Responsible_Role;
            bool? Is_Active = request.Is_Active;
            Byte[] Log = request.Log;
            Guid? ApplicationCode = request.ApplicationCode;
            string Application_NO = request.Application_NO;
            string Doc_No = request.Doc_No;
            Guid? Assigned_By = request.Assigned_By;
            bool? Is_Owner = request.Is_Owner;

            IList<Innitiative_Plan_Assignment_IPA_ID> result = await _procedureAdabter
                .Execute<Innitiative_Plan_Assignment_IPA_ID>("[BSC].[Innitiative_Plan_AssignmentUpdate]", 
                (nameof(IPA_ID), IPA_ID),
                (nameof(Innitiative_ID), Innitiative_ID),
                (nameof(Assigned_Body), Assigned_Body),
                (nameof(Responsible_Role), Responsible_Role),
                (nameof(Is_Active), Is_Active),
                (nameof(Log), Log),
                (nameof(ApplicationCode), ApplicationCode),
                (nameof(Application_NO), Application_NO),
                (nameof(Doc_No), Doc_No),
                (nameof(Assigned_By), Assigned_By),
                (nameof(Is_Owner), Is_Owner));

            return result;
        }
    }
}
