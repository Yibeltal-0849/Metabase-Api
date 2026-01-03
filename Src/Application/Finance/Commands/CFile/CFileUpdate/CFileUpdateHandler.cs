

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;



namespace Application.Finance.Commands.CFile.CFileUpdate.CFileUpdateCommand
{

    /// @author  Shimels Alem  C_FileUpdate stored procedure.


    public class CFileUpdateHandler : IRequestHandler<CFileUpdateCommand, IList<CFile_C_File_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public CFileUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<CFile_C_File_ID>> Handle( CFileUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<CFile_C_File_ID> result = await _procedureAdabter
                .Execute<CFile_C_File_ID>("[FINA].C_FileUpdate", request);
           

            return result;
        }
    }
}
 