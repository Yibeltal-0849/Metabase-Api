using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.HRA.Commands.OT_Record.DeleteOT_Record
{
    public class DeleteOT_RecordHandler : IRequestHandler<DeleteOT_RecordCommand, IList<OtRecord_OT_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public DeleteOT_RecordHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<OtRecord_OT_ID>> Handle(DeleteOT_RecordCommand request, CancellationToken cancellationToken)
        {
            Guid OT_ID = request.OT_ID;
            IList<OtRecord_OT_ID> result = await _procedureAdabter
                .Execute<OtRecord_OT_ID>("[HRA].[OT_RecordDelete]",
                (nameof(OT_ID), OT_ID));

            return result;
        }
    }
}
