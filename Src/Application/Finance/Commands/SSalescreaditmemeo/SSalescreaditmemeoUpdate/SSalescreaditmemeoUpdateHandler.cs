

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;



namespace Application.Finance.Commands.SSalescreaditmemeo.SSalescreaditmemeoUpdate.SSalescreaditmemeoUpdateCommand
{

    /// @author  Shimels Alem  S_Sales_creadit_memeoUpdate stored procedure.


    public class SSalescreaditmemeoUpdateHandler : IRequestHandler<SSalescreaditmemeoUpdateCommand, IList<SSalesCreaditMemeo_Sales_Credit_Line_Id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public SSalescreaditmemeoUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<SSalesCreaditMemeo_Sales_Credit_Line_Id>> Handle( SSalescreaditmemeoUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<SSalesCreaditMemeo_Sales_Credit_Line_Id> result = await _procedureAdabter
                .Execute<SSalesCreaditMemeo_Sales_Credit_Line_Id>("[FINA].S_Sales_creadit_memeoUpdate", request);
           

            return result;
        }
    }
}
 