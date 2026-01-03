

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;



namespace Application.Finance.Commands.CTax.CTaxUpdate.CTaxUpdateCommand
{

    /// @author  Shimels Alem  C_TaxUpdate stored procedure.


    public class CTaxUpdateHandler : IRequestHandler<CTaxUpdateCommand, IList<CTax_Code>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public CTaxUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<CTax_Code>> Handle( CTaxUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<CTax_Code> result = await _procedureAdabter
                .Execute<CTax_Code>("[FINA].C_TaxUpdate", request);
           

            return result;
        }
    }
}
 