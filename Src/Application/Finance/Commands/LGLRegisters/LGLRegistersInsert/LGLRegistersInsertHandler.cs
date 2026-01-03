



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;


namespace Application.Finance.Commands.LGLRegisters.LGLRegistersInsert.LGLRegistersInsertCommand
{

    /// @author  Shimels Alem  L_G_L_RegistersInsert stored procedure.


    public class LGLRegistersInsertHandler : IRequestHandler<LGLRegistersInsertCommand, IList<LGLRegisters_Branch_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public LGLRegistersInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<LGLRegisters_Branch_ID>> Handle( LGLRegistersInsertCommand request, CancellationToken cancellationToken)
        {

            IList<LGLRegisters_Branch_ID> result = await _procedureAdabter
                .Execute<LGLRegisters_Branch_ID>("[FINA].L_G_L_RegistersInsert", request);
           

            return result;
        }
    }
}
 