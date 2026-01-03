

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;



namespace Application.ProprtyData.Commands.procProportyAssignment.procProportyAssignmentUpdate.procProportyAssignmentUpdateCommand
{

    /// @author  Shimels Alem  proc_Rent_CollectionUpdate stored procedure.


    public class procProportyAssignmentUpdateCommandHandler : IRequestHandler<procProportyAssignmentUpdateCommand, IList<Proporty_AssignmentID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procProportyAssignmentUpdateCommandHandler (IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Proporty_AssignmentID>> Handle(procProportyAssignmentUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<Proporty_AssignmentID> result = await _procedureAdabter
                .Execute<Proporty_AssignmentID>("[ProprtyData].[proc_Proporty_AssignmentUpdate]", request);
           

            return result;
        }
    }
}
 