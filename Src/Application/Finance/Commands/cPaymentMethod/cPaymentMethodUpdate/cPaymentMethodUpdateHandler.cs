

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;



namespace Application.Finance.Commands.cPaymentMethod.cPaymentMethodUpdate.cPaymentMethodUpdateCommand
{

    /// @author  Shimels Alem  c_PaymentMethodUpdate stored procedure.


    public class cPaymentMethodUpdateHandler : IRequestHandler<cPaymentMethodUpdateCommand, IList<CPaymentMethod_Id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public cPaymentMethodUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<CPaymentMethod_Id>> Handle( cPaymentMethodUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<CPaymentMethod_Id> result = await _procedureAdabter
                .Execute<CPaymentMethod_Id>("[FINA].c_PaymentMethodUpdate", request);
           
            return result;
        }
    }
}
 