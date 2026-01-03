



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;


namespace Application.Finance.Commands.CTax.CTaxInsert.CTaxInsertCommand
{

    /// @author  Shimels Alem  C_TaxInsert stored procedure.


    public class CTaxInsertHandler : IRequestHandler<CTaxInsertCommand, IList<CTax_Code>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public CTaxInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<CTax_Code>> Handle( CTaxInsertCommand request, CancellationToken cancellationToken)
        {

            IList<CTax_Code> result = await _procedureAdabter
                .Execute<CTax_Code>("[FINA].C_TaxInsert", request);
           

            return result;
        }
    }
}
 