



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;


namespace Application.Finance.Commands.SSalescreaditmemeo.SSalescreaditmemeoInsert.SSalescreaditmemeoInsertCommand
{

    /// @author  Shimels Alem  S_Sales_creadit_memeoInsert stored procedure.


    public class SSalescreaditmemeoInsertHandler : IRequestHandler<SSalescreaditmemeoInsertCommand, IList<SSalesCreaditMemeo_Sales_Credit_Line_Id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public SSalescreaditmemeoInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<SSalesCreaditMemeo_Sales_Credit_Line_Id>> Handle( SSalescreaditmemeoInsertCommand request, CancellationToken cancellationToken)
        {

            IList<SSalesCreaditMemeo_Sales_Credit_Line_Id> result = await _procedureAdabter
                .Execute<SSalesCreaditMemeo_Sales_Credit_Line_Id>("[FINA].S_Sales_creadit_memeoInsert", request);
           

            return result;
        }
    }
}
 