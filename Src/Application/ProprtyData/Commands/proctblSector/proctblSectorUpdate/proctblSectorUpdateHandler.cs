

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;



namespace Application.ProprtyData.Commands.proctblSector.proctblSectorUpdate.proctblSectorUpdateCommand
{

    /// @author  Shimels Alem  [sp not found]  stored procedure.


    public class proctblSectorUpdateHandler : IRequestHandler<proctblSectorUpdateCommand, IList<tblSector_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proctblSectorUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<tblSector_id>> Handle( proctblSectorUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<tblSector_id> result = await _procedureAdabter
                .Execute<tblSector_id>("[ProprtyData].[sp not found]", request);
           
            return result;
        }
    }
}
 