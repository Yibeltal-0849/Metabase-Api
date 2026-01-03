



using AutoMapper;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Interfaces;
using System.Collections.Generic;
using XOKA.Domain.Entities.dbo;


namespace Application.dbo.Commands.procapplications.procapplicationsInsert.procapplicationsInsertCommand
{

    /// @author  Shimels Alem  proc_applicationsInsert stored procedure.


    public class procapplicationsInsertHandler : IRequestHandler<procapplicationsInsertCommand, IList<applications_applicationcode>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procapplicationsInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<applications_applicationcode>> Handle( procapplicationsInsertCommand request, CancellationToken cancellationToken)
        {

            IList<applications_applicationcode> result = await _procedureAdabter
                .Execute<applications_applicationcode>("[dbo].proc_applicationsInsert", request);
           

            return result;
        }
    }
}
 