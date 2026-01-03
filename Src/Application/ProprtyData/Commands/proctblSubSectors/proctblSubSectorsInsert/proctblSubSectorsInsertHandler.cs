



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;


namespace Application.ProprtyData.Commands.proctblSubSectors.proctblSubSectorsInsert.proctblSubSectorsInsertCommand
{

    /// @author  Shimels Alem  proc_tblSubSectorsInsert stored procedure.


    public class proctblSubSectorsInsertHandler : IRequestHandler<proctblSubSectorsInsertCommand, IList<tblSubSectors_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proctblSubSectorsInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<tblSubSectors_id>> Handle( proctblSubSectorsInsertCommand request, CancellationToken cancellationToken)
        {

            IList<tblSubSectors_id> result = await _procedureAdabter
                .Execute<tblSubSectors_id>("[ProprtyData].proc_tblSubSectorsInsert", request);
           

            return result;
        }
    }
}
 