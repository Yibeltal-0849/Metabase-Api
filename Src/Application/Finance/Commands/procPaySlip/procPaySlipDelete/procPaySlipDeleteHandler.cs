using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.procPaySlip.procPaySlipDelete.procPaySlipDeleteCommand
{

    /// @author  Shimels Alem  proc_Pay_SlipDelete stored procedure.


    public class procPaySlipDeleteHandler : IRequestHandler<procPaySlipDeleteCommand, IList<PaySlip_Pay_Slip_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procPaySlipDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<PaySlip_Pay_Slip_ID>> Handle( procPaySlipDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<PaySlip_Pay_Slip_ID> result = await _procedureAdabter
                .Execute<PaySlip_Pay_Slip_ID>("[FINA].proc_Pay_SlipDelete", request);
           

            return result;
        }
    }
}
  