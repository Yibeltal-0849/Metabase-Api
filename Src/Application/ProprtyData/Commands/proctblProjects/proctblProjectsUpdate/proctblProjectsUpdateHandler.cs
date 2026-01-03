

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;



namespace Application.ProprtyData.Commands.proctblProjects.proctblProjectsUpdate.proctblProjectsUpdateCommand
{

    /// @author  Shimels Alem  proc_tblProjectsUpdate stored procedure.


    public class proctblProjectsUpdateHandler : IRequestHandler<proctblProjectsUpdateCommand, IList<tblProjects_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proctblProjectsUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<tblProjects_id>> Handle( proctblProjectsUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<tblProjects_id> result = await _procedureAdabter
                .Execute<tblProjects_id>("[ProprtyData].proc_tblProjectsUpdate", request);
           

            return result;
        }
    }
}
 