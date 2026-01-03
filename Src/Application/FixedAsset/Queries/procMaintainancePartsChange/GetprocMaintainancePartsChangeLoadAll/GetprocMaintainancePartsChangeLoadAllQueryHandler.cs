using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.FixedAsset;
using XOKA.Domain.Interfaces;

namespace Application.FixedAsset.Quiries.procMaintainancePartsChange.GetprocMaintainancePartsChangeLoadAll
{
    class GetprocMaintainancePartsChangeLoadAllQueryHandler : IRequestHandler<GetprocMaintainancePartsChangeLoadAllQuery, GetprocMaintainancePartsChangeLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocMaintainancePartsChangeLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocMaintainancePartsChangeLoadAllListVm> Handle(GetprocMaintainancePartsChangeLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<MaintainancePartsChange> procMaintainancePartsChanges = await _procedureAdabter
               .Execute<MaintainancePartsChange>("[FixedAsset].[proc_Maintainance_PartsChangeLoadAll]");
            GetprocMaintainancePartsChangeLoadAllListVm vm = new GetprocMaintainancePartsChangeLoadAllListVm
            {
                procMaintainancePartsChanges = _mapper.Map<IList<MaintainancePartsChange>, IList<GetprocMaintainancePartsChangeLoadAllVm>>(procMaintainancePartsChanges)
            };

            return vm;
        }
    }
}
