



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;


namespace Application.ProprtyData.Commands.proctblImportDescriptions.proctblImportDescriptionsInsert.proctblImportDescriptionsInsertCommand
{

    /// @author  Shimels Alem  proc_tblImport_DescriptionsInsert stored procedure.


    public class proctblImportDescriptionsInsertHandler : IRequestHandler<proctblImportDescriptionsInsertCommand, IList<tblImportDescriptions_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proctblImportDescriptionsInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<tblImportDescriptions_id>> Handle( proctblImportDescriptionsInsertCommand request, CancellationToken cancellationToken)
        {

            IList<tblImportDescriptions_id> result = await _procedureAdabter
                .Execute<tblImportDescriptions_id>("[ProprtyData].proc_tblImport_DescriptionsInsert", request);
           

            return result;
        }
    }
}
 