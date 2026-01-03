using AutoMapper;
using MediatR;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Commands.proctblImportDescriptions.proctblImportDescriptionsDelete.proctblImportDescriptionsDeleteCommand
{

    /// @author  Shimels Alem  proc_tblImport_DescriptionsDelete stored procedure.


    public class proctblImportDescriptionsDeleteHandler : IRequestHandler<proctblImportDescriptionsDeleteCommand, IList<tblImportDescriptions_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proctblImportDescriptionsDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<tblImportDescriptions_id>> Handle( proctblImportDescriptionsDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<tblImportDescriptions_id> result = await _procedureAdabter
                .Execute<tblImportDescriptions_id>("[ProprtyData].proc_tblImport_DescriptionsDelete", request);
           

            return result;
        }
    }
}
  