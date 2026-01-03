using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.ProprtyData.Queries.proctblResource.GetproctblResourceLoadAll;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Queries.proctblResource.GetproctblResourceByPrimaryKey
{
    public class GetproctblResourceQueryHandler : IRequestHandler<GetproctblResourceByPrimaryKey, GetproctblResourceLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetproctblResourceQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproctblResourceLoadAllListVm> Handle(GetproctblResourceByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<tblResource> proctblResources = await _procedureAdabter
               .Execute<tblResource>("[ProprtyData].[proc_tblResourceLoadByPrimaryKey]", request);
            GetproctblResourceLoadAllListVm vm = new GetproctblResourceLoadAllListVm
            {
                proctblResources = _mapper.Map<IList<tblResource>, IList<GetproctblResourceLoadAllVm>>(proctblResources)
            };

            return vm;
        }
    }
}
