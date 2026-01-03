

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;



namespace Application.Finance.Commands.cPayMethodscustomer.cPayMethodscustomerUpdate.cPayMethodscustomerUpdateCommand
{

    /// @author  Shimels Alem  c_Pay_Methods_customerUpdate stored procedure.


    public class cPayMethodscustomerUpdateHandler : IRequestHandler<cPayMethodscustomerUpdateCommand, IList<CPayMethodsCustomer_Id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public cPayMethodscustomerUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<CPayMethodsCustomer_Id>> Handle( cPayMethodscustomerUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<CPayMethodsCustomer_Id> result = await _procedureAdabter
                .Execute<CPayMethodsCustomer_Id>("[FINA].c_Pay_Methods_customerUpdate", request);
           

            return result;
        }
    }
}
 