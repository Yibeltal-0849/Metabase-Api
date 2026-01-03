using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Commands.proctblImport.proctblImportDelete.proctblImportDeleteCommand
{

    /// @author  Shimels Alem  proc_tblImportDelete stored procedure.


    public class proctblImportDeleteHandler : IRequestHandler<proctblImportDeleteCommand, IList<tblImport_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proctblImportDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<tblImport_id>> Handle( proctblImportDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<tblImport_id> result = await _procedureAdabter
                .Execute<tblImport_id>("[ProprtyData].proc_tblImportDelete", request);
           

            return result;
        }
    }
}
  