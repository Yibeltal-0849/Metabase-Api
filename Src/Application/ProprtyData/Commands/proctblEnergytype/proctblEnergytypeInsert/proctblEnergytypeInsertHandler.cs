



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;


namespace Application.ProprtyData.Commands.proctblEnergytype.proctblEnergytypeInsert.proctblEnergytypeInsertCommand
{

    /// @author  Shimels Alem  proc_tblEnergy_typeInsert stored procedure.


    public class proctblEnergytypeInsertHandler : IRequestHandler<proctblEnergytypeInsertCommand, IList<tblEnergytype_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proctblEnergytypeInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<tblEnergytype_id>> Handle( proctblEnergytypeInsertCommand request, CancellationToken cancellationToken)
        {

            IList<tblEnergytype_id> result = await _procedureAdabter
                .Execute<tblEnergytype_id>("[ProprtyData].proc_tblEnergy_typeInsert", request);
           

            return result;
        }
    }
}
 