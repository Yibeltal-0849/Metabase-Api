

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;



namespace Application.ProprtyData.Commands.proctblImport.proctblImportUpdate.proctblImportUpdateCommand
{

    /// @author  Shimels Alem  proc_tblImportUpdate stored procedure.


    public class proctblImportUpdateHandler : IRequestHandler<proctblImportUpdateCommand, IList<tblImport_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proctblImportUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<tblImport_id>> Handle( proctblImportUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<tblImport_id> result = await _procedureAdabter
                .Execute<tblImport_id>("[ProprtyData].proc_tblImportUpdate", request);
           

            return result;
        }
    }
}
 