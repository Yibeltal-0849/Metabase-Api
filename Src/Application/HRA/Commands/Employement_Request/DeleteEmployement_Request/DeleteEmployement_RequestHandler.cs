using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.HRA.Commands.Employement_Request.DeleteEmployement_Request
{
    public class DeleteEmployement_RequestHandler : IRequestHandler<DeleteEmployement_RequestCommand, IList<EmployementRequest_JOBPost_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public DeleteEmployement_RequestHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<EmployementRequest_JOBPost_ID>> Handle(DeleteEmployement_RequestCommand request, CancellationToken cancellationToken)
        {
            Guid JOBPost_ID = request.JOBPost_ID;
            IList<EmployementRequest_JOBPost_ID> result = await _procedureAdabter
                .Execute<EmployementRequest_JOBPost_ID>("[HRA].[Employement_RequestDelete]",
                (nameof(JOBPost_ID), JOBPost_ID));

            return result;
        }
    }
}
