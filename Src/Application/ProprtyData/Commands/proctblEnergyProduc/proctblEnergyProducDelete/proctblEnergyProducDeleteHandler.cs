using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Commands.proctblEnergyProduc.proctblEnergyProducDelete.proctblEnergyProducDeleteCommand
{

    /// @author  Shimels Alem  proc_tblEnergyProducDelete stored procedure.


    public class proctblEnergyProducDeleteHandler : IRequestHandler<proctblEnergyProducDeleteCommand, IList<tblEnergyProduc_Id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proctblEnergyProducDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<tblEnergyProduc_Id>> Handle( proctblEnergyProducDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<tblEnergyProduc_Id> result = await _procedureAdabter
                .Execute<tblEnergyProduc_Id>("[ProprtyData].proc_tblEnergyProducDelete", request);
           

            return result;
        }
    }
}
  