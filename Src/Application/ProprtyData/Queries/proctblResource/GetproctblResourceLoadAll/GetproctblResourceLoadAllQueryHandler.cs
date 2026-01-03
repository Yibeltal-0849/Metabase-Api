using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Queries.proctblResource.GetproctblResourceLoadAll
{
    class GetproctblResourceLoadAllQueryHandler : IRequestHandler<GetproctblResourceLoadAllQuery, GetproctblResourceLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetproctblResourceLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproctblResourceLoadAllListVm> Handle(GetproctblResourceLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<tblResource> proctblResources = await _procedureAdabter
               .Execute<tblResource>("[ProprtyData].[proc_tblResourceLoadAll]");
            GetproctblResourceLoadAllListVm vm = new GetproctblResourceLoadAllListVm
            {
                proctblResources = _mapper.Map<IList<tblResource>, IList<GetproctblResourceLoadAllVm>>(proctblResources)
            };

            return vm;
        }
    }
}
