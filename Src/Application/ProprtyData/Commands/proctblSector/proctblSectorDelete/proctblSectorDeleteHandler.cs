using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Commands.proctblSector.proctblSectorDelete.proctblSectorDeleteCommand
{

    /// @author  Shimels Alem  proc_tblSectorDelete stored procedure.


    public class proctblSectorDeleteHandler : IRequestHandler<proctblSectorDeleteCommand, IList<tblSector_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proctblSectorDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<tblSector_id>> Handle( proctblSectorDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<tblSector_id> result = await _procedureAdabter
                .Execute<tblSector_id>("[ProprtyData].proc_tblSectorDelete", request);
           

            return result;
        }
    }
}
  