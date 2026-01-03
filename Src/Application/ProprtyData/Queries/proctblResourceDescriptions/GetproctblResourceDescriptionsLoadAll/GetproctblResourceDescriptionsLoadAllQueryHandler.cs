using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Queries.proctblResourceDescriptions.GetproctblResourceDescriptionsLoadAll
{
    class GetproctblResourceDescriptionsLoadAllQueryHandler : IRequestHandler<GetproctblResourceDescriptionsLoadAllQuery, GetproctblResourceDescriptionsLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetproctblResourceDescriptionsLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproctblResourceDescriptionsLoadAllListVm> Handle(GetproctblResourceDescriptionsLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<tblResourceDescriptions> proctblResourceDescriptionss = await _procedureAdabter
               .Execute<tblResourceDescriptions>("[ProprtyData].[proc_tblResourceDescriptionsLoadAll]");
            GetproctblResourceDescriptionsLoadAllListVm vm = new GetproctblResourceDescriptionsLoadAllListVm
            {
                proctblResourceDescriptionss = _mapper.Map<IList<tblResourceDescriptions>, IList<GetproctblResourceDescriptionsLoadAllVm>>(proctblResourceDescriptionss)
            };

            return vm;
        }
    }
}
