using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Queries.proctblExportDescriptions.GetproctblExportDescriptionsLoadAll
{
    class GetproctblExportDescriptionsLoadAllQueryHandler : IRequestHandler<GetproctblExportDescriptionsLoadAllQuery, GetproctblExportDescriptionsLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetproctblExportDescriptionsLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproctblExportDescriptionsLoadAllListVm> Handle(GetproctblExportDescriptionsLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<tblExportDescriptions> proctblExportDescriptionss = await _procedureAdabter
               .Execute<tblExportDescriptions>("[ProprtyData].[proc_tblExport_DescriptionsLoadAll]");
            GetproctblExportDescriptionsLoadAllListVm vm = new GetproctblExportDescriptionsLoadAllListVm
            {
                proctblExportDescriptionss = _mapper.Map<IList<tblExportDescriptions>, IList<GetproctblExportDescriptionsLoadAllVm>>(proctblExportDescriptionss)
            };

            return vm;
        }
    }
}
