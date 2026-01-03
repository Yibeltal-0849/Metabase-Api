using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.FixedAsset.Quiries.procMaintainancePartsChange.GetprocMaintainancePartsChangeLoadAll;
using XOKA.Domain.Entities.FixedAsset;
using XOKA.Domain.Interfaces;

namespace Application.FixedAsset.Quiries.procMaintainancePartsChange.GetprocMaintainancePartsChangeByPrimaryKey
{
    public class GetprocMaintainancePartsChangeQueryHandler : IRequestHandler<GetprocMaintainancePartsChangeByPrimaryKey, GetprocMaintainancePartsChangeLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocMaintainancePartsChangeQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocMaintainancePartsChangeLoadAllListVm> Handle(GetprocMaintainancePartsChangeByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<MaintainancePartsChange> procMaintainancePartsChanges = await _procedureAdabter
               .Execute<MaintainancePartsChange>("[FixedAsset].[proc_Maintainance_PartsChangeLoadByPrimaryKey]", request);
            GetprocMaintainancePartsChangeLoadAllListVm vm = new GetprocMaintainancePartsChangeLoadAllListVm
            {
                procMaintainancePartsChanges = _mapper.Map<IList<MaintainancePartsChange>, IList<GetprocMaintainancePartsChangeLoadAllVm>>(procMaintainancePartsChanges)
            };

            return vm;
        }
    }
}
