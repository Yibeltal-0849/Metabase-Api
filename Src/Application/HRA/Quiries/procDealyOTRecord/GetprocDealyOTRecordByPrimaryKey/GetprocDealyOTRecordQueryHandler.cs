using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.HRA.Quiries.procDealyOTRecord.GetprocDealyOTRecordLoadAll;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace Application.HRA.Quiries.procDealyOTRecord.GetprocDealyOTRecordByPrimaryKey
{
    public class GetprocDealyOTRecordQueryHandler : IRequestHandler<GetprocDealyOTRecordByPrimaryKey, GetprocDealyOTRecordLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocDealyOTRecordQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocDealyOTRecordLoadAllListVm> Handle(GetprocDealyOTRecordByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<DealyOtRecord> procDealyOTRecords = await _procedureAdabter
               .Execute<DealyOtRecord>("[HRA].[proc_Dealy_OT_RecordLoadByPrimaryKey]", request);
            GetprocDealyOTRecordLoadAllListVm vm = new GetprocDealyOTRecordLoadAllListVm
            {
                procDealyOTRecords = _mapper.Map<IList<DealyOtRecord>, IList<GetprocDealyOTRecordLoadAllVm>>(procDealyOTRecords)
            };

            return vm;
        }
    }
}
