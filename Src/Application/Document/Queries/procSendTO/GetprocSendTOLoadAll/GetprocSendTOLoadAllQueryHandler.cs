using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Document;
using XOKA.Domain.Interfaces;

namespace Application.Document.Quiries.procSendTO.GetprocSendTOLoadAll
{
    class GetprocSendTOLoadAllQueryHandler : IRequestHandler<GetprocSendTOLoadAllQuery, GetprocSendTOLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocSendTOLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocSendTOLoadAllListVm> Handle(GetprocSendTOLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<SendTO> procSendTOs = await _procedureAdabter
               .Execute<SendTO>("[Document].[proc_Send_TOLoadAll]");
            GetprocSendTOLoadAllListVm vm = new GetprocSendTOLoadAllListVm
            {
                procSendTOs = _mapper.Map<IList<SendTO>, IList<GetprocSendTOLoadAllVm>>(procSendTOs)
            };

            return vm;
        }
    }
}
