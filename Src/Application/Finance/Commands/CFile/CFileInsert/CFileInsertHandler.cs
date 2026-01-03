



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;


namespace Application.Finance.Commands.CFile.CFileInsert.CFileInsertCommand
{

    /// @author  Shimels Alem  C_FileInsert stored procedure.


    public class CFileInsertHandler : IRequestHandler<CFileInsertCommand, IList<CFile_C_File_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public CFileInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<CFile_C_File_ID>> Handle( CFileInsertCommand request, CancellationToken cancellationToken)
        {

            IList<CFile_C_File_ID> result = await _procedureAdabter
                .Execute<CFile_C_File_ID>("[FINA].C_FileInsert", request);
           
            return result;
        }
    }
}
 