using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.HRA.Quiries.CFile.GetCFileLoadAll
{
    class GetCFileLoadAllQueryHandler : IRequestHandler<GetCFileLoadAllQuery, GetCFileLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetCFileLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetCFileLoadAllListVm> Handle(GetCFileLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<Proc_C_File> Files = await _procedureAdabter
               .Execute<Proc_C_File>("[HRA].[proc_C_FileLoadAll]");
            GetCFileLoadAllListVm vm = new GetCFileLoadAllListVm
            {
                Files = _mapper.Map<IList<Proc_C_File>, IList<GetCFileLoadAllVm>>(Files)
            };

            return vm;
        }
    }
}
