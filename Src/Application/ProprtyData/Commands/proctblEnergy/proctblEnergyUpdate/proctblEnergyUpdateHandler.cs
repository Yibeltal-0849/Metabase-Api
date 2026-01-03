

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;



namespace Application.ProprtyData.Commands.proctblEnergy.proctblEnergyUpdate.proctblEnergyUpdateCommand
{ 
	 
	/// @author  Shimels Alem  'no sp fond' stored procedure.
	 
	 
      public class proctblEnergyUpdateHandler : IRequestHandler<proctblEnergyUpdateCommand, IList<tblEnergy_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proctblEnergyUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<tblEnergy_id>> Handle( proctblEnergyUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<tblEnergy_id> result = await _procedureAdabter
                .Execute<tblEnergy_id>("[ProprtyData].[proc_tblEnergyUpdate]", request);
           

            return result;
        }
    }
}
 