



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;


namespace Application.ProprtyData.Commands.proctblEnergyProduc.proctblEnergyProducInsert.proctblEnergyProducInsertCommand
{

    /// @author  Shimels Alem  proc_tblEnergyProducInsert stored procedure.


    public class proctblEnergyProducInsertHandler : IRequestHandler<proctblEnergyProducInsertCommand, IList<tblEnergyProduc_Id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proctblEnergyProducInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<tblEnergyProduc_Id>> Handle( proctblEnergyProducInsertCommand request, CancellationToken cancellationToken)
        {

            IList<tblEnergyProduc_Id> result = await _procedureAdabter
                .Execute<tblEnergyProduc_Id>("[ProprtyData].proc_tblEnergyProducInsert", request);
           

            return result;
        }
    }
}
 