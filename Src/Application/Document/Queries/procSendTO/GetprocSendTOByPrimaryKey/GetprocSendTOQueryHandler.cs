using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Document.Quiries.procSendTO.GetprocSendTOLoadAll;
using XOKA.Domain.Entities.Document;
using XOKA.Domain.Interfaces;

namespace Application.Document.Quiries.procSendTO.GetprocSendTOByPrimaryKey
{
    public class GetprocSendTOQueryHandler : IRequestHandler<GetprocSendTOByPrimaryKey, GetprocSendTOLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocSendTOQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocSendTOLoadAllListVm> Handle(GetprocSendTOByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<SendTO> procSendTOs = await _procedureAdabter
               .Execute<SendTO>("[Document].[proc_Send_TOLoadByPrimaryKey]", request);
            GetprocSendTOLoadAllListVm vm = new GetprocSendTOLoadAllListVm
            {
                procSendTOs = _mapper.Map<IList<SendTO>, IList<GetprocSendTOLoadAllVm>>(procSendTOs)
            };

            return vm;
        }
    }
}
