



using AutoMapper;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Interfaces;
using XOKA.Domain.Entities.Finance;
using System.Collections.Generic;


namespace Application.Finance.Commands.procdocumenttypes.procdocumenttypesInsert.procdocumenttypesInsertCommand
{

    /// @author  Shimels Alem  proc_document_typesInsert stored procedure.


    public class procdocumenttypesInsertHandler : IRequestHandler<procdocumenttypesInsertCommand, IList<documenttypes_documenttypecode>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procdocumenttypesInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<documenttypes_documenttypecode>> Handle( procdocumenttypesInsertCommand request, CancellationToken cancellationToken)
        {

            IList<documenttypes_documenttypecode> result = await _procedureAdabter
                .Execute<documenttypes_documenttypecode>("[FINA].proc_document_typesInsert", request);
           

            return result;
        }
    }
}
 