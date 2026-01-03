using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Commands.procProportyAssignment.procProportyAssignmentDelete.procProportyAssignmentDeleteCommand
{

    /// @author  Shimels Alem  proc_Rent_CollectionDelete stored procedure.


    public class procProportyAssignmentDeleteHandler : IRequestHandler<procProportyAssignmentDeleteCommand, IList<Proporty_AssignmentID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procProportyAssignmentDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Proporty_AssignmentID>> Handle(procProportyAssignmentDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<Proporty_AssignmentID> result = await _procedureAdabter
                .Execute<Proporty_AssignmentID>("[ProprtyData].[proc_Proporty_AssignmentDelete]", request);
           

            return result;
        }
    }
}
  