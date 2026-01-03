



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;


namespace Application.ProprtyData.Commands.proctblExport.proctblExportInsert.proctblExportInsertCommand
{

    /// @author  Shimels Alem  proc_tblExportInsert stored procedure.


    public class proctblExportInsertHandler : IRequestHandler<proctblExportInsertCommand, IList<tblExport_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proctblExportInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<tblExport_id>> Handle( proctblExportInsertCommand request, CancellationToken cancellationToken)
        {

            IList<tblExport_id> result = await _procedureAdabter
                .Execute<tblExport_id>("[ProprtyData].proc_tblExportInsert", request);
           

            return result;
        }
    }
}
 