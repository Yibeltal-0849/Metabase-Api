



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;


namespace Application.ProprtyData.Commands.ProcProportyStaticData.ProcProportyStaticDataInsert.ProcProportyStaticDataInsertCommand
{

    /// @author  Shimels Alem  proc_Rent_CollectionInsert stored procedure.


    public class ProcProportyStaticDataInsertHandler : IRequestHandler<ProcProportyStaticDataInsertCommand, IList<Proporty_Static_DataID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public ProcProportyStaticDataInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Proporty_Static_DataID>> Handle(ProcProportyStaticDataInsertCommand request, CancellationToken cancellationToken)
        {

            IList<Proporty_Static_DataID> result = await _procedureAdabter
                .Execute<Proporty_Static_DataID>("[ProprtyData].[proc_Proporty_Static_DataInsert]", request);
                                                 
           

            return result;
        }
    }
}
 