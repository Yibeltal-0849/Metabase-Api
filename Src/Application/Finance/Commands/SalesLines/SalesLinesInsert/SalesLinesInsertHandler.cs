



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;


namespace Application.Finance.Commands.SalesLines.SalesLinesInsert.SalesLinesInsertCommand
{

    /// @author  Shimels Alem  Sales_LinesInsert stored procedure.


    public class SalesLinesInsertHandler : IRequestHandler<SalesLinesInsertCommand, IList<Sales_Lines_Sales_Line_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public SalesLinesInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Sales_Lines_Sales_Line_ID>> Handle( SalesLinesInsertCommand request, CancellationToken cancellationToken)
        {

            IList<Sales_Lines_Sales_Line_ID> result = await _procedureAdabter
                .Execute<Sales_Lines_Sales_Line_ID>("[FINA].Sales_LinesInsert", request);
           

            return result;
        }
    }
}
 