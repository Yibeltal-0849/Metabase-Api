using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.ProprtyData.Queries.proctblExportDescriptions.GetproctblExportDescriptionsLoadAll;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Queries.proctblExportDescriptions.GetproctblExportDescriptionsByPrimaryKey
{
    public class GetproctblExportDescriptionsQueryHandler : IRequestHandler<GetproctblExportDescriptionsByPrimaryKey, GetproctblExportDescriptionsLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetproctblExportDescriptionsQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproctblExportDescriptionsLoadAllListVm> Handle(GetproctblExportDescriptionsByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<tblExportDescriptions> proctblExportDescriptionss = await _procedureAdabter
               .Execute<tblExportDescriptions>("[ProprtyData].[proc_tblExport_DescriptionsLoadByPrimaryKey]", request);
            GetproctblExportDescriptionsLoadAllListVm vm = new GetproctblExportDescriptionsLoadAllListVm
            {
                proctblExportDescriptionss = _mapper.Map<IList<tblExportDescriptions>, IList<GetproctblExportDescriptionsLoadAllVm>>(proctblExportDescriptionss)
            };

            return vm;
        }
    }
}
