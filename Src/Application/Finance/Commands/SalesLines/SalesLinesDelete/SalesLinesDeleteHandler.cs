using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.SalesLines.SalesLinesDelete.SalesLinesDeleteCommand
{

    /// @author  Shimels Alem  Sales_LinesDelete stored procedure.


    public class SalesLinesDeleteHandler : IRequestHandler<SalesLinesDeleteCommand, IList<Sales_Lines_Sales_Line_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public SalesLinesDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Sales_Lines_Sales_Line_ID>> Handle( SalesLinesDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<Sales_Lines_Sales_Line_ID> result = await _procedureAdabter
                .Execute<Sales_Lines_Sales_Line_ID>("[FINA].Sales_LinesDelete", request);
           

            return result;
        }
    }
}
  