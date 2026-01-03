



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;


namespace Application.ProprtyData.Commands.proctblWoredas.proctblWoredasInsert.proctblWoredasInsertCommand
{

    /// @author  Shimels Alem  proc_tblWoredasInsert stored procedure.


    public class proctblWoredasInsertHandler : IRequestHandler<proctblWoredasInsertCommand, IList<tblWoredas_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proctblWoredasInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<tblWoredas_id>> Handle( proctblWoredasInsertCommand request, CancellationToken cancellationToken)
        {

            IList<tblWoredas_id> result = await _procedureAdabter
                .Execute<tblWoredas_id>("[ProprtyData].proc_tblWoredasInsert", request);
           

            return result;
        }
    }
}
 