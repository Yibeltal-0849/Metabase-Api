using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace Application.HRA.Quiries.procDealyOTRecord.GetprocDealyOTRecordLoadAll
{
    class GetprocDealyOTRecordLoadAllQueryHandler : IRequestHandler<GetprocDealyOTRecordLoadAllQuery, GetprocDealyOTRecordLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocDealyOTRecordLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocDealyOTRecordLoadAllListVm> Handle(GetprocDealyOTRecordLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<DealyOtRecord> procDealyOTRecords = await _procedureAdabter
               .Execute<DealyOtRecord>("[HRA].[proc_Dealy_OT_RecordLoadAll]");
            GetprocDealyOTRecordLoadAllListVm vm = new GetprocDealyOTRecordLoadAllListVm
            {
                procDealyOTRecords = _mapper.Map<IList<DealyOtRecord>, IList<GetprocDealyOTRecordLoadAllVm>>(procDealyOTRecords)
            };

            return vm;
        }
    }
}
