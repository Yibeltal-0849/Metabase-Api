using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Commands.proctblExportDescriptions.proctblExportDescriptionsDelete.proctblExportDescriptionsDeleteCommand
{

    /// @author  Shimels Alem  proc_tblExport_DescriptionsDelete stored procedure.


    public class proctblExportDescriptionsDeleteHandler : IRequestHandler<proctblExportDescriptionsDeleteCommand, IList<tblExportDescriptions_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proctblExportDescriptionsDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<tblExportDescriptions_id>> Handle( proctblExportDescriptionsDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<tblExportDescriptions_id> result = await _procedureAdabter
                .Execute<tblExportDescriptions_id>("[ProprtyData].proc_tblExport_DescriptionsDelete", request);
           

            return result;
        }
    }
}
  