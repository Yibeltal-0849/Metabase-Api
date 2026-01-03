using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.ProprtyData.Queries.proctblResourceDescriptions.GetproctblResourceDescriptionsLoadAll;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Queries.proctblResourceDescriptions.GetproctblResourceDescriptionsByPrimaryKey
{
    public class GetproctblResourceDescriptionsQueryHandler : IRequestHandler<GetproctblResourceDescriptionsByPrimaryKey, GetproctblResourceDescriptionsLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetproctblResourceDescriptionsQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproctblResourceDescriptionsLoadAllListVm> Handle(GetproctblResourceDescriptionsByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<tblResourceDescriptions> proctblResourceDescriptionss = await _procedureAdabter
               .Execute<tblResourceDescriptions>("[ProprtyData].[proc_tblResourceDescriptionsLoadByPrimaryKey]", request);
            GetproctblResourceDescriptionsLoadAllListVm vm = new GetproctblResourceDescriptionsLoadAllListVm
            {
                proctblResourceDescriptionss = _mapper.Map<IList<tblResourceDescriptions>, IList<GetproctblResourceDescriptionsLoadAllVm>>(proctblResourceDescriptionss)
            };

            return vm;
        }
    }
}
