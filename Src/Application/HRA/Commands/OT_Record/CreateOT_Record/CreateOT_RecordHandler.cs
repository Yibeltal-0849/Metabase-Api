using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.HRA.Commands.OT_Record.CreateOT_Record
{
    public class CreateOT_RecordHandler : IRequestHandler<CreateOT_RecordCommand, IList<OtRecord_OT_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public CreateOT_RecordHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<OtRecord_OT_ID>> Handle(CreateOT_RecordCommand request, CancellationToken cancellationToken)
        {

            IList<OtRecord_OT_ID> result = await _procedureAdabter
                    .Execute<OtRecord_OT_ID>("[HRA].[OT_RecordInsert]", request);

            return result;
        }

    }
}
