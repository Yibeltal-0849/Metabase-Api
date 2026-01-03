using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.SSalescreaditmemeo.SSalescreaditmemeoDelete.SSalescreaditmemeoDeleteCommand
{

    /// @author  Shimels Alem  S_Sales_creadit_memeoDelete stored procedure.


    public class SSalescreaditmemeoDeleteHandler : IRequestHandler<SSalescreaditmemeoDeleteCommand, IList<SSalesCreaditMemeo_Sales_Credit_Line_Id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public SSalescreaditmemeoDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<SSalesCreaditMemeo_Sales_Credit_Line_Id>> Handle( SSalescreaditmemeoDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<SSalesCreaditMemeo_Sales_Credit_Line_Id> result = await _procedureAdabter
                .Execute<SSalesCreaditMemeo_Sales_Credit_Line_Id>("[FINA].S_Sales_creadit_memeoDelete", request);
           

            return result;
        }
    }
}
  