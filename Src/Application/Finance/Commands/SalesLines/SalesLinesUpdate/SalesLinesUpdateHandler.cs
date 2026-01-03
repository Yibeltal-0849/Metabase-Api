

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;



namespace Application.Finance.Commands.SalesLines.SalesLinesUpdate.SalesLinesUpdateCommand
{

    /// @author  Shimels Alem  Sales_LinesUpdate stored procedure.


    public class SalesLinesUpdateHandler : IRequestHandler<SalesLinesUpdateCommand, IList<Sales_Lines_Sales_Line_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public SalesLinesUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Sales_Lines_Sales_Line_ID>> Handle( SalesLinesUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<Sales_Lines_Sales_Line_ID> result = await _procedureAdabter
                .Execute<Sales_Lines_Sales_Line_ID>("[FINA].Sales_LinesUpdate", request);
           

            return result;
        }
    }
}
 