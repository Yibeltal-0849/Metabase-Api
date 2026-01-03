using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.HRA.Commands.CFile.DeleteCFile
{
    public class DeleteCFileHandler : IRequestHandler<DeleteCFileCommand, IList<Proc_C_File_C_File_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public DeleteCFileHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Proc_C_File_C_File_ID>> Handle(DeleteCFileCommand request, CancellationToken cancellationToken)
        {
            Guid C_File_ID = request.C_File_ID;
            IList<Proc_C_File_C_File_ID> result = await _procedureAdabter
                .Execute<Proc_C_File_C_File_ID>("[HRA].[proc_C_FileDelete]", (nameof(C_File_ID), C_File_ID));

            return result;
        }
    }
}
