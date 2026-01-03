using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.HRA.Commands.Work_Info.DeleteWork_Info
{
    public class DeleteWork_InfoHandler : IRequestHandler<DeleteWork_InfoCommand, IList<WorkInfo_WorkInfo_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public DeleteWork_InfoHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<WorkInfo_WorkInfo_ID>> Handle(DeleteWork_InfoCommand request, CancellationToken cancellationToken)
        {
            Guid WorkInfo_ID = request.WorkInfo_ID;
            IList<WorkInfo_WorkInfo_ID> result = await _procedureAdabter
                .Execute<WorkInfo_WorkInfo_ID>("[HRA].[Work_InfoDelete]",
                (nameof(WorkInfo_ID), WorkInfo_ID));

            return result;
        }
    }
}
