



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;


namespace Application.ProprtyData.Commands.procProportyTypeLockup.procProportyTypeLockupInsert.procProportyTypeLockupInsertCommand
{

    /// @author  Shimels Alem  proc_Rent_CollectionInsert stored procedure.


    public class procProportyTypeLockupInsertHandler : IRequestHandler<procProportyTypeLockupInsertCommand, IList<Proporty_Type_LookUpID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procProportyTypeLockupInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Proporty_Type_LookUpID>> Handle(procProportyTypeLockupInsertCommand request, CancellationToken cancellationToken)
        {

            IList<Proporty_Type_LookUpID> result = await _procedureAdabter
                .Execute<Proporty_Type_LookUpID>("[ProprtyData].[proc_Property_Type_LookupInsert]", request);
                                                 
           

            return result;
        }
    }
}
 