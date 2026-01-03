using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Queries.proctblResourceStatus.GetproctblResourceStatusLoadAll
{
    class GetproctblResourceStatusLoadAllQueryHandler : IRequestHandler<GetproctblResourceStatusLoadAllQuery, GetproctblResourceStatusLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetproctblResourceStatusLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproctblResourceStatusLoadAllListVm> Handle(GetproctblResourceStatusLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<tblResourceStatus> proctblResourceStatuss = await _procedureAdabter
               .Execute<tblResourceStatus>("[ProprtyData].[proc_tblResource_StatusLoadAll]");
            GetproctblResourceStatusLoadAllListVm vm = new GetproctblResourceStatusLoadAllListVm
            {
                proctblResourceStatuss = _mapper.Map<IList<tblResourceStatus>, IList<GetproctblResourceStatusLoadAllVm>>(proctblResourceStatuss)
            };

            return vm;
        }
    }
}
