using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.HRA.Commands.Dealy_OT_Record.CreateDealy_OT_Record
{
    public class CreateDealy_OT_RecordHandler : IRequestHandler<CreateDealy_OT_RecordCommand, IList<DealyOtRecord_Dealy_OT_Record_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public CreateDealy_OT_RecordHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<DealyOtRecord_Dealy_OT_Record_ID>> Handle(CreateDealy_OT_RecordCommand request, CancellationToken cancellationToken)
        {

            IList<DealyOtRecord_Dealy_OT_Record_ID> result = await _procedureAdabter
                    .Execute<DealyOtRecord_Dealy_OT_Record_ID>("[HRA].[Dealy_OT_RecordInsert]", request);

            return result;
        }

    }
}
