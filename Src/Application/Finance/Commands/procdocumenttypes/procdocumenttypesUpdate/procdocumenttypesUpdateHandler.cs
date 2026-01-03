

using AutoMapper;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Interfaces;
using XOKA.Domain.Entities.Finance;
using System.Collections.Generic;



namespace Application.Finance.Commands.procdocumenttypes.procdocumenttypesUpdate.procdocumenttypesUpdateCommand
{

    /// @author  Shimels Alem  proc_document_typesUpdate stored procedure.


    public class procdocumenttypesUpdateHandler : IRequestHandler<procdocumenttypesUpdateCommand, IList<documenttypes_documenttypecode>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procdocumenttypesUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<documenttypes_documenttypecode>> Handle( procdocumenttypesUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<documenttypes_documenttypecode> result = await _procedureAdabter
                .Execute<documenttypes_documenttypecode>("[FINA].proc_document_typesUpdate", request);
           

            return result;
        }
    }
}
 