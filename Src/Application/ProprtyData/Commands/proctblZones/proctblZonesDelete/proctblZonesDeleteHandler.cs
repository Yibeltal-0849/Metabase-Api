using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Commands.proctblZones.proctblZonesDelete.proctblZonesDeleteCommand
{

    /// @author  Shimels Alem  proc_tblZonesDelete stored procedure.


    public class proctblZonesDeleteHandler : IRequestHandler<proctblZonesDeleteCommand, IList<tblZones_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proctblZonesDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<tblZones_id>> Handle( proctblZonesDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<tblZones_id> result = await _procedureAdabter
                .Execute<tblZones_id>("[ProprtyData].proc_tblZonesDelete", request);
           

            return result;
        }
    }
}
  