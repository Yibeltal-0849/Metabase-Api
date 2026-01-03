using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace Application.HRA.Quiries.procOTRecord.GetprocOTRecordLoadAll
{
    class GetprocOTRecordLoadAllQueryHandler : IRequestHandler<GetprocOTRecordLoadAllQuery, GetprocOTRecordLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocOTRecordLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocOTRecordLoadAllListVm> Handle(GetprocOTRecordLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<OtRecord> procOTRecords = await _procedureAdabter
               .Execute<OtRecord>("[HRA].[proc_OT_RecordLoadAll]");
            GetprocOTRecordLoadAllListVm vm = new GetprocOTRecordLoadAllListVm
            {
                procOTRecords = _mapper.Map<IList<OtRecord>, IList<GetprocOTRecordLoadAllVm>>(procOTRecords)
            };

            return vm;
        }
    }
}
