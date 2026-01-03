using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.HRA.Commands.OT_Record.UpdateOT_Record
{
    public class UpdateCOT_RecordHandler : IRequestHandler<UpdateCOT_RecordCommand, IList<OtRecord_OT_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public UpdateCOT_RecordHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<OtRecord_OT_ID>> Handle(UpdateCOT_RecordCommand request, CancellationToken cancellationToken)
        {

            IList<OtRecord_OT_ID> result = await _procedureAdabter
                .Execute<OtRecord_OT_ID>("[HRA].[OT_RecordUpdate]", request);

            return result;
        }
    }
}
