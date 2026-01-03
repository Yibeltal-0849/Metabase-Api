using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Commands.proctblExport.proctblExportDelete.proctblExportDeleteCommand
{

    /// @author  Shimels Alem  proc_tblExportDelete stored procedure.


    public class proctblExportDeleteHandler : IRequestHandler<proctblExportDeleteCommand, IList<tblExport_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proctblExportDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<tblExport_id>> Handle( proctblExportDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<tblExport_id> result = await _procedureAdabter
                .Execute<tblExport_id>("[ProprtyData].proc_tblExportDelete", request);
           

            return result;
        }
    }
}
  