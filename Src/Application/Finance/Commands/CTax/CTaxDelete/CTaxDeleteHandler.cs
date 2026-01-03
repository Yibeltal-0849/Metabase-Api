using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.CTax.CTaxDelete.CTaxDeleteCommand
{

    /// @author  Shimels Alem  C_TaxDelete stored procedure.


    public class CTaxDeleteHandler : IRequestHandler<CTaxDeleteCommand, IList<CTax_Code>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public CTaxDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<CTax_Code>> Handle( CTaxDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<CTax_Code> result = await _procedureAdabter
                .Execute<CTax_Code>("[FINA].C_TaxDelete", request);
           

            return result;
        }
    }
}
  