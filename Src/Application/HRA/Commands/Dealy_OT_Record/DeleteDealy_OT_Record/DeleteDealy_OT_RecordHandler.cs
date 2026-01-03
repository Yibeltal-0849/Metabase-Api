using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.HRA.Commands.Dealy_OT_Record.DeleteDealy_OT_Record
{
    public class DeleteDealy_OT_RecordHandler : IRequestHandler<DeleteDealy_OT_RecordCommand, IList<DealyOtRecord_Dealy_OT_Record_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public DeleteDealy_OT_RecordHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<DealyOtRecord_Dealy_OT_Record_ID>> Handle(DeleteDealy_OT_RecordCommand request, CancellationToken cancellationToken)
        {
            Guid? Dealy_OT_Record_ID = request.Dealy_OT_Record_ID;
            IList<DealyOtRecord_Dealy_OT_Record_ID> result = await _procedureAdabter
                .Execute<DealyOtRecord_Dealy_OT_Record_ID>("[HRA].[Dealy_OT_RecordDelete]",
                (nameof(Dealy_OT_Record_ID), Dealy_OT_Record_ID));

            return result;
        }
    }
}
