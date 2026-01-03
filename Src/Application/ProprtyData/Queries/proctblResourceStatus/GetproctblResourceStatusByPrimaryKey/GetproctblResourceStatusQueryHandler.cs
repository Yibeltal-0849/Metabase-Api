using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.ProprtyData.Queries.proctblResourceStatus.GetproctblResourceStatusLoadAll;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Queries.proctblResourceStatus.GetproctblResourceStatusByPrimaryKey
{
    public class GetproctblResourceStatusQueryHandler : IRequestHandler<GetproctblResourceStatusByPrimaryKey, GetproctblResourceStatusLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetproctblResourceStatusQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproctblResourceStatusLoadAllListVm> Handle(GetproctblResourceStatusByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<tblResourceStatus> proctblResourceStatuss = await _procedureAdabter
               .Execute<tblResourceStatus>("[ProprtyData].[proc_tblResource_StatusLoadByPrimaryKey]", request);
            GetproctblResourceStatusLoadAllListVm vm = new GetproctblResourceStatusLoadAllListVm
            {
                proctblResourceStatuss = _mapper.Map<IList<tblResourceStatus>, IList<GetproctblResourceStatusLoadAllVm>>(proctblResourceStatuss)
            };

            return vm;
        }
    }
}
