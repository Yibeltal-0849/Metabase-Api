using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.HRA.Commands.Job_Application.DeleteJob_Application
{
    public class DeleteJob_ApplicationHandler : IRequestHandler<DeleteJob_ApplicationCommand, IList<JobApplication_Job_AppID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public DeleteJob_ApplicationHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<JobApplication_Job_AppID>> Handle(DeleteJob_ApplicationCommand request, CancellationToken cancellationToken)
        {
            string Job_AppID = request.Job_AppID;
            IList<JobApplication_Job_AppID> result = await _procedureAdabter
                .Execute<JobApplication_Job_AppID>("[HRA].[Job_ApplicationDelete]",
                (nameof(Job_AppID), Job_AppID));

            return result;
        }
    }
}
