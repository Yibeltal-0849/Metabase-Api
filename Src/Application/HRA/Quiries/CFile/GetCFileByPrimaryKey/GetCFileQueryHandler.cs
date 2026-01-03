using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Application.HRA.Quiries.CFile.GetCFileLoadAll;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.HRA.Quiries.CFile.GetCFileByPrimaryKey
{
    public class GetCFileQueryHandler : IRequestHandler<GetCFileByPrimaryKey, GetCFileLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetCFileQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetCFileLoadAllListVm> Handle(GetCFileByPrimaryKey request, CancellationToken cancellationToken)
        {
            Guid C_File_ID = request.C_File_ID;
            IList<Proc_C_File> Files = await _procedureAdabter
               .Execute<Proc_C_File>("[HRA].[proc_C_FileLoadByPrimaryKey]", (nameof(C_File_ID), C_File_ID));
            GetCFileLoadAllListVm vm = new GetCFileLoadAllListVm
            {
                Files = _mapper.Map<IList<Proc_C_File>, IList<GetCFileLoadAllVm>>(Files)
            };

            return vm;
        }
    }
}
