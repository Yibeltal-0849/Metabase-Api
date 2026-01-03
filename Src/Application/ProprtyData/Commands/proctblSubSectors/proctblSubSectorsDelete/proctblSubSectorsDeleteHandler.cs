using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Commands.proctblSubSectors.proctblSubSectorsDelete.proctblSubSectorsDeleteCommand
{

    /// @author  Shimels Alem  proc_tblSubSectorsDelete stored procedure.


    public class proctblSubSectorsDeleteHandler : IRequestHandler<proctblSubSectorsDeleteCommand, IList<tblSubSectors_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proctblSubSectorsDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<tblSubSectors_id>> Handle( proctblSubSectorsDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<tblSubSectors_id> result = await _procedureAdabter
                .Execute<tblSubSectors_id>("[ProprtyData].proc_tblSubSectorsDelete", request);
           

            return result;
        }
    }
}
  