

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;



namespace Application.Finance.Commands.LGLRegisters.LGLRegistersUpdate.LGLRegistersUpdateCommand
{

    /// @author  Shimels Alem  L_G_L_RegistersUpdate stored procedure.


    public class LGLRegistersUpdateHandler : IRequestHandler<LGLRegistersUpdateCommand, IList<LGLRegisters_Branch_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public LGLRegistersUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<LGLRegisters_Branch_ID>> Handle( LGLRegistersUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<LGLRegisters_Branch_ID> result = await _procedureAdabter
                .Execute<LGLRegisters_Branch_ID>("[FINA].L_G_L_RegistersUpdate", request);
           

            return result;
        }
    }
}
 