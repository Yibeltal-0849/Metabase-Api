using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.HRA.Commands.CFile.UpdateCFile
{
    public class UpdateCFileHandler : IRequestHandler<UpdateCFileCommand, IList<Proc_C_File_C_File_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public UpdateCFileHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Proc_C_File_C_File_ID>> Handle(UpdateCFileCommand request, CancellationToken cancellationToken)
        {
            Guid C_File_ID = request.C_File_ID;
            string AD_Table_ID = request.AD_Table_ID;
            string AD_Record_ID = request.AD_Record_ID;

            IList<Proc_C_File_C_File_ID> result = await _procedureAdabter
                .Execute<Proc_C_File_C_File_ID>("[HRA].[proc_C_FileUpdate]", 
                (nameof(C_File_ID), C_File_ID),
                (nameof(AD_Table_ID), AD_Table_ID),
                (nameof(AD_Record_ID), AD_Record_ID));

            return result;
        }
    }
}
