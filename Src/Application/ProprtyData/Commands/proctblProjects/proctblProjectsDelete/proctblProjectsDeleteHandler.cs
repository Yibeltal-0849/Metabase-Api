using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Commands.proctblProjects.proctblProjectsDelete.proctblProjectsDeleteCommand
{

    /// @author  Shimels Alem  proc_tblProjectsDelete stored procedure.


    public class proctblProjectsDeleteHandler : IRequestHandler<proctblProjectsDeleteCommand, IList<tblProjects_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proctblProjectsDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<tblProjects_id>> Handle( proctblProjectsDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<tblProjects_id> result = await _procedureAdabter
                .Execute<tblProjects_id>("[ProprtyData].proc_tblProjectsDelete", request);
           

            return result;
        }
    }
}
  