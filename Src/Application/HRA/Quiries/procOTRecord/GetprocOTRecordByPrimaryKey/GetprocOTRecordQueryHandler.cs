using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.HRA.Quiries.procOTRecord.GetprocOTRecordLoadAll;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace Application.HRA.Quiries.procOTRecord.GetprocOTRecordByPrimaryKey
{
    public class GetprocOTRecordQueryHandler : IRequestHandler<GetprocOTRecordByPrimaryKey, GetprocOTRecordLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocOTRecordQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocOTRecordLoadAllListVm> Handle(GetprocOTRecordByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<OtRecord> procOTRecords = await _procedureAdabter
               .Execute<OtRecord>("[HRA].[proc_OT_RecordLoadByPrimaryKey]", request);
            GetprocOTRecordLoadAllListVm vm = new GetprocOTRecordLoadAllListVm
            {
                procOTRecords = _mapper.Map<IList<OtRecord>, IList<GetprocOTRecordLoadAllVm>>(procOTRecords)
            };

            return vm;
        }
    }
}
