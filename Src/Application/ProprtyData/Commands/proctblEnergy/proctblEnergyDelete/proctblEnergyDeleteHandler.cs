using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Commands.proctblEnergy.proctblEnergyDelete.proctblEnergyDeleteCommand
{

    /// @author  Shimels Alem  proc_tblEnergyDelete stored procedure.


    public class proctblEnergyDeleteHandler : IRequestHandler<proctblEnergyDeleteCommand, IList<tblEnergy_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proctblEnergyDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<tblEnergy_id>> Handle( proctblEnergyDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<tblEnergy_id> result = await _procedureAdabter
                .Execute<tblEnergy_id>("[ProprtyData].proc_tblEnergyDelete", request);
           

            return result;
        }
    }
}
  