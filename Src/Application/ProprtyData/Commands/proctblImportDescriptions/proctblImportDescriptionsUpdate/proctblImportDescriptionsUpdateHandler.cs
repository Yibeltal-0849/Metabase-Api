

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;



namespace Application.ProprtyData.Commands.proctblImportDescriptions.proctblImportDescriptionsUpdate.proctblImportDescriptionsUpdateCommand
{

    /// @author  Shimels Alem  proc_tblImport_DescriptionsUpdate stored procedure.


    public class proctblImportDescriptionsUpdateHandler : IRequestHandler<proctblImportDescriptionsUpdateCommand, IList<tblImportDescriptions_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proctblImportDescriptionsUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<tblImportDescriptions_id>> Handle( proctblImportDescriptionsUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<tblImportDescriptions_id> result = await _procedureAdabter
                .Execute<tblImportDescriptions_id>("[ProprtyData].proc_tblImport_DescriptionsUpdate", request);
           

            return result;
        }
    }
}
 