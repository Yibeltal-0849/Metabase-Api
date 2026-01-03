using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.cPaymentMethod.cPaymentMethodDelete.cPaymentMethodDeleteCommand
{

    /// @author  Shimels Alem  c_PaymentMethodDelete stored procedure.


    public class cPaymentMethodDeleteHandler : IRequestHandler<cPaymentMethodDeleteCommand, IList<CPaymentMethod_Id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public cPaymentMethodDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<CPaymentMethod_Id>> Handle( cPaymentMethodDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<CPaymentMethod_Id> result = await _procedureAdabter
                .Execute<CPaymentMethod_Id>("[FINA].c_PaymentMethodDelete", request);
           

            return result;
        }
    }
}
  