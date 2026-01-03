

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;



namespace Application.ProprtyData.Commands.proctblEnergytype.proctblEnergytypeUpdate.proctblEnergytypeUpdateCommand
{

    /// @author  Shimels Alem  proc_tblEnergy_typeUpdate stored procedure.


    public class proctblEnergytypeUpdateHandler : IRequestHandler<proctblEnergytypeUpdateCommand, IList<tblEnergytype_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proctblEnergytypeUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<tblEnergytype_id>> Handle( proctblEnergytypeUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<tblEnergytype_id> result = await _procedureAdabter
                .Execute<tblEnergytype_id>("[ProprtyData].proc_tblEnergy_typeUpdate", request);
           

            return result;
        }
    }
}
 