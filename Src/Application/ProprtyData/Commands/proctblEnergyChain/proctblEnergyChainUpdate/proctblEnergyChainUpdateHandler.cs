

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;



namespace Application.ProprtyData.Commands.proctblEnergyChain.proctblEnergyChainUpdate.proctblEnergyChainUpdateCommand
{ 
	 
	/// @author  Shimels Alem  XXXXX stored procedure.
	 
	 
      public class proctblEnergyChainUpdateHandler : IRequestHandler<proctblEnergyChainUpdateCommand, IList<tblEnergyChain_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proctblEnergyChainUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<tblEnergyChain_id>> Handle( proctblEnergyChainUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<tblEnergyChain_id> result = await _procedureAdabter
                .Execute<tblEnergyChain_id>("[ProprtyData].[sp not found]", request);
           

            return result;
        }
    }
}
 