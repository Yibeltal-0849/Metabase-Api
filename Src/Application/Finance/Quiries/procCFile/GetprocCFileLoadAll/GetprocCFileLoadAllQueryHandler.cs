using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.procCFile.GetprocCFileLoadAll
{
    class GetprocCFileLoadAllQueryHandler : IRequestHandler<GetprocCFileLoadAllQuery, GetprocCFileLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocCFileLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocCFileLoadAllListVm> Handle(GetprocCFileLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<CFile> procCFiles = await _procedureAdabter
               .Execute<CFile>("[FINA].[proc_C_FileLoadAll]");
            GetprocCFileLoadAllListVm vm = new GetprocCFileLoadAllListVm
            {
                procCFiles = _mapper.Map<IList<CFile>, IList<GetprocCFileLoadAllVm>>(procCFiles)
            };

            return vm;
        }
    }
}
