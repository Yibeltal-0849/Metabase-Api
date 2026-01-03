



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;


namespace Application.ProprtyData.Commands.proctblEnergyTypeChain.proctblEnergyTypeChainInsert.proctblEnergyTypeChainInsertCommand
{

    /// @author  Shimels Alem  proc_tblEnergy_Type_ChainInsert stored procedure.


    public class proctblEnergyTypeChainInsertHandler : IRequestHandler<proctblEnergyTypeChainInsertCommand, IList<tblEnergyTypeChain_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proctblEnergyTypeChainInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<tblEnergyTypeChain_id>> Handle( proctblEnergyTypeChainInsertCommand request, CancellationToken cancellationToken)
        {

            IList<tblEnergyTypeChain_id> result = await _procedureAdabter
                .Execute<tblEnergyTypeChain_id>("[ProprtyData].proc_tblEnergy_Type_ChainInsert", request);
           

            return result;
        }
    }
}
 