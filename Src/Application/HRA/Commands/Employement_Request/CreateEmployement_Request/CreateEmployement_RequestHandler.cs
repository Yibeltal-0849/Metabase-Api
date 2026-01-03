using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.HRA.Commands.Employement_Request.CreateEmployement_Request
{
    public class CreateEmployement_RequestHandler : IRequestHandler<CreateEmployement_RequestCommand, IList<EmployementRequest_JOBPost_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public CreateEmployement_RequestHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<EmployementRequest_JOBPost_ID>> Handle(CreateEmployement_RequestCommand request, CancellationToken cancellationToken)
        {

            IList<EmployementRequest_JOBPost_ID> result = await _procedureAdabter
                .Execute<EmployementRequest_JOBPost_ID>("[HRA].[Employement_RequestInsert]", request);

            return result;
        }

    }
}
