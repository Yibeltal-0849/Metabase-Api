

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;



namespace Application.ProprtyData.Commands.proctblSubSectors.proctblSubSectorsUpdate.proctblSubSectorsUpdateCommand
{

    /// @author  Shimels Alem  proc_tblSubSectorsUpdate stored procedure.


    public class proctblSubSectorsUpdateHandler : IRequestHandler<proctblSubSectorsUpdateCommand, IList<tblSubSectors_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proctblSubSectorsUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<tblSubSectors_id>> Handle( proctblSubSectorsUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<tblSubSectors_id> result = await _procedureAdabter
                .Execute<tblSubSectors_id>("[ProprtyData].proc_tblSubSectorsUpdate", request);
           

            return result;
        }
    }
}
 