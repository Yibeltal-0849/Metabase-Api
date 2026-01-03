

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;



namespace Application.ProprtyData.Commands.proctblEnergyTypeChain.proctblEnergyTypeChainUpdate.proctblEnergyTypeChainUpdateCommand
{

    /// @author  Shimels Alem  proc_tblEnergy_Type_ChainUpdate stored procedure.


    public class proctblEnergyTypeChainUpdateHandler : IRequestHandler<proctblEnergyTypeChainUpdateCommand, IList<tblEnergyTypeChain_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proctblEnergyTypeChainUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<tblEnergyTypeChain_id>> Handle( proctblEnergyTypeChainUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<tblEnergyTypeChain_id> result = await _procedureAdabter
                .Execute<tblEnergyTypeChain_id>("[ProprtyData].proc_tblEnergy_Type_ChainUpdate", request);
           

            return result;
        }
    }
}
 