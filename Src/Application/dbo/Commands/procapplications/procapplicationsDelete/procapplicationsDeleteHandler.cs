using AutoMapper;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Interfaces;
using System.Collections.Generic;
using XOKA.Domain.Entities.dbo;

namespace Application.dbo.Commands.procapplications.procapplicationsDelete.procapplicationsDeleteCommand
{

    /// @author  Shimels Alem  proc_applicationsDelete stored procedure.


    public class procapplicationsDeleteHandler : IRequestHandler<procapplicationsDeleteCommand, IList<applications_applicationcode>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procapplicationsDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<applications_applicationcode>> Handle( procapplicationsDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<applications_applicationcode> result = await _procedureAdabter
                .Execute<applications_applicationcode>("[dbo].proc_applicationsDelete", request);
           
            return result;
        }
    }
}
  