using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.HRA.Commands.Work_Info.UpdateWork_Info
{
    public class UpdateWork_InfoHandler : IRequestHandler<UpdateWork_InfoCommand, IList<WorkInfo_WorkInfo_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public UpdateWork_InfoHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<WorkInfo_WorkInfo_ID>> Handle(UpdateWork_InfoCommand request, CancellationToken cancellationToken)
        {

            IList<WorkInfo_WorkInfo_ID> result = await _procedureAdabter
                .Execute<WorkInfo_WorkInfo_ID>("[HRA].[Work_InfoUpdate]", request);

            return result;
        }
    }
}
