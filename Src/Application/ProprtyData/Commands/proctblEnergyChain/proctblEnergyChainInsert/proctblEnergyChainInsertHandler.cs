



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;


namespace Application.ProprtyData.Commands.proctblEnergyChain.proctblEnergyChainInsert.proctblEnergyChainInsertCommand
{

    /// @author  Shimels Alem  proc_tblEnergyChainInsert stored procedure.


    public class proctblEnergyChainInsertHandler : IRequestHandler<proctblEnergyChainInsertCommand, IList<tblEnergyChain_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proctblEnergyChainInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<tblEnergyChain_id>> Handle( proctblEnergyChainInsertCommand request, CancellationToken cancellationToken)
        {

            IList<tblEnergyChain_id> result = await _procedureAdabter
                .Execute<tblEnergyChain_id>("[ProprtyData].proc_tblEnergyChainInsert", request);
           

            return result;
        }
    }
}
 