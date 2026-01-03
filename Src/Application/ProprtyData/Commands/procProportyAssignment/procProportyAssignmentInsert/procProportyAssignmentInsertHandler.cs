



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;


namespace Application.ProprtyData.Commands.procProportyAssignment.procProportyAssignmentInsert.procProportyAssignmentInsertCommand
{

    /// @author  Shimels Alem  proc_Rent_CollectionInsert stored procedure.


    public class procProportyAssignmentInsertHandler : IRequestHandler<procProportyAssignmentInsertCommand, IList<Proporty_AssignmentID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procProportyAssignmentInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Proporty_AssignmentID>> Handle(procProportyAssignmentInsertCommand request, CancellationToken cancellationToken)
        {

            IList<Proporty_AssignmentID> result = await _procedureAdabter
                .Execute<Proporty_AssignmentID>("[ProprtyData].[proc_Proporty_AssignmentInsert]", request);
                                                 
           

            return result;
        }
    }
}
 