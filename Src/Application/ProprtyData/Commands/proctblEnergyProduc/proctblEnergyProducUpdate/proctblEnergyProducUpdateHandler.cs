

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;



namespace Application.ProprtyData.Commands.proctblEnergyProduc.proctblEnergyProducUpdate.proctblEnergyProducUpdateCommand
{

    /// @author  Shimels Alem  proc_tblEnergyProducUpdate stored procedure.


    public class proctblEnergyProducUpdateHandler : IRequestHandler<proctblEnergyProducUpdateCommand, IList<tblEnergyProduc_Id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proctblEnergyProducUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<tblEnergyProduc_Id>> Handle( proctblEnergyProducUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<tblEnergyProduc_Id> result = await _procedureAdabter
                .Execute<tblEnergyProduc_Id>("[ProprtyData].proc_tblEnergyProducUpdate", request);
           

            return result;
        }
    }
}
 