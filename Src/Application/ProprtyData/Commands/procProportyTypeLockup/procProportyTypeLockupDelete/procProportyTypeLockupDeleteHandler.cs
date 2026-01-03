using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Commands.procProportyTypeLockup.procProportyTypeLockupDelete.procProportyTypeLockupDeleteCommand
{

    /// @author  Shimels Alem  proc_Rent_CollectionDelete stored procedure.


    public class procProportyTypeLockupDeleteHandler : IRequestHandler<procProportyTypeLockupDeleteCommand, IList<Proporty_Type_LookUpID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procProportyTypeLockupDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Proporty_Type_LookUpID>> Handle(procProportyTypeLockupDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<Proporty_Type_LookUpID> result = await _procedureAdabter
                .Execute<Proporty_Type_LookUpID>("[ProprtyData].[proc_Property_Type_LookupDelete]", request);
           

            return result;
        }
    }
}
  