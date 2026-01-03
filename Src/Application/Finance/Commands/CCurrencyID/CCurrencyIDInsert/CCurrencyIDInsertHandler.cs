



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;


namespace Application.Finance.Commands.CCurrencyID.CCurrencyIDInsert.CCurrencyIDInsertCommand
{

    /// @author  Shimels Alem  C_Currency_IDInsert stored procedure.


    public class CCurrencyIDInsertHandler : IRequestHandler<CCurrencyIDInsertCommand, IList<CCurrencyId_CurrencyID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public CCurrencyIDInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<CCurrencyId_CurrencyID>> Handle( CCurrencyIDInsertCommand request, CancellationToken cancellationToken)
        {

            IList<CCurrencyId_CurrencyID> result = await _procedureAdabter
                .Execute<CCurrencyId_CurrencyID>("[FINA].C_Currency_IDInsert", request);
           

            return result;
        }
    }
}
 