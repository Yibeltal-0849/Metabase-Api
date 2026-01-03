



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;


namespace Application.Finance.Commands.cPaymentMethod.cPaymentMethodInsert.cPaymentMethodInsertCommand
{

    /// @author  Shimels Alem  c_PaymentMethodInsert stored procedure.


    public class cPaymentMethodInsertHandler : IRequestHandler<cPaymentMethodInsertCommand, IList<CPaymentMethod_Id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public cPaymentMethodInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<CPaymentMethod_Id>> Handle( cPaymentMethodInsertCommand request, CancellationToken cancellationToken)
        {

            IList<CPaymentMethod_Id> result = await _procedureAdabter
                .Execute<CPaymentMethod_Id>("[FINA].c_PaymentMethodInsert", request);
           

            return result;
        }
    }
}
 