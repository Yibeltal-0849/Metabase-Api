

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;



namespace Application.Finance.Commands.procPaySlip.procPaySlipUpdate.procPaySlipUpdateCommand
{ 
	 
	/// @author  Shimels Alem  proc_Pay_SlipUpdate stored procedure.
	 
	 
      public class procPaySlipUpdateHandler : IRequestHandler<procPaySlipUpdateCommand, IList<PaySlip_Pay_Slip_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procPaySlipUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<PaySlip_Pay_Slip_ID>> Handle( procPaySlipUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<PaySlip_Pay_Slip_ID> result = await _procedureAdabter
                .Execute<PaySlip_Pay_Slip_ID>("[FINA].proc_Pay_SlipUpdate", request);
           

            return result;
        }
    }
}
 