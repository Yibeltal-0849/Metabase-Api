using AutoMapper;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Interfaces;
using XOKA.Domain.Entities.Finance;
using System.Collections.Generic;

namespace Application.Finance.Commands.procdocumenttypes.procdocumenttypesDelete.procdocumenttypesDeleteCommand
{

    /// @author  Shimels Alem  proc_document_typesDelete stored procedure.


    public class procdocumenttypesDeleteHandler : IRequestHandler<procdocumenttypesDeleteCommand, IList<documenttypes_documenttypecode>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procdocumenttypesDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<documenttypes_documenttypecode>> Handle( procdocumenttypesDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<documenttypes_documenttypecode> result = await _procedureAdabter
                .Execute<documenttypes_documenttypecode>("[FINA].proc_document_typesDelete", request);
           

            return result;
        }
    }
}
  