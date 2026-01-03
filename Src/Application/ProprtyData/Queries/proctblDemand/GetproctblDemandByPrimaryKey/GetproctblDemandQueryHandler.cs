using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.ProprtyData.Queries.proctblDemand.GetproctblDemandLoadAll;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Queries.proctblDemand.GetproctblDemandByPrimaryKey
{
    public class GetproctblDemandQueryHandler : IRequestHandler<GetproctblDemandByPrimaryKey, GetproctblDemandLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetproctblDemandQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproctblDemandLoadAllListVm> Handle(GetproctblDemandByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<tblDemand> proctblDemands = await _procedureAdabter
               .Execute<tblDemand>("[ProprtyData].[proc_tblDemandLoadByPrimaryKey]", request);
            GetproctblDemandLoadAllListVm vm = new GetproctblDemandLoadAllListVm
            {
                proctblDemands = _mapper.Map<IList<tblDemand>, IList<GetproctblDemandLoadAllVm>>(proctblDemands)
            };

            return vm;
        }
    }
}
