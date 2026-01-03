using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Finance.Quiries.procCFile.GetprocCFileLoadAll;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.procCFile.GetprocCFileByPrimaryKey
{
    public class GetprocCFileQueryHandler : IRequestHandler<GetprocCFileByPrimaryKey, GetprocCFileLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocCFileQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocCFileLoadAllListVm> Handle(GetprocCFileByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<CFile> procCFiles = await _procedureAdabter
               .Execute<CFile>("[FINA].[proc_C_FileLoadByPrimaryKey]", request);
            GetprocCFileLoadAllListVm vm = new GetprocCFileLoadAllListVm
            {
                procCFiles = _mapper.Map<IList<CFile>, IList<GetprocCFileLoadAllVm>>(procCFiles)
            };

            return vm;
        }
    }
}
