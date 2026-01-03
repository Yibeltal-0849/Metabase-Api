



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;


namespace Application.Finance.Commands.procPaySlip.procPaySlipInsert.procPaySlipInsertCommand
{

    /// @author  Shimels Alem  proc_Pay_SlipInsert stored procedure.


    public class procPaySlipInsertHandler : IRequestHandler<procPaySlipInsertCommand, IList<PaySlip_Pay_Slip_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procPaySlipInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<PaySlip_Pay_Slip_ID>> Handle( procPaySlipInsertCommand request, CancellationToken cancellationToken)
        {

            IList<PaySlip_Pay_Slip_ID> result = await _procedureAdabter
                .Execute<PaySlip_Pay_Slip_ID>("[FINA].proc_Pay_SlipInsert", request);
           

            return result;
        }
    }
}
 