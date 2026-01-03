



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;


namespace Application.ProprtyData.Commands.proctblEnergy.proctblEnergyInsert.proctblEnergyInsertCommand
{

    /// @author  Shimels Alem  proc_tblEnergyInsert stored procedure.


    public class proctblEnergyInsertHandler : IRequestHandler<proctblEnergyInsertCommand, IList<tblEnergy_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proctblEnergyInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<tblEnergy_id>> Handle( proctblEnergyInsertCommand request, CancellationToken cancellationToken)
        {

            IList<tblEnergy_id> result = await _procedureAdabter
                .Execute<tblEnergy_id>("[ProprtyData].proc_tblEnergyInsert", request);
           

            return result;
        }
    }
}
 