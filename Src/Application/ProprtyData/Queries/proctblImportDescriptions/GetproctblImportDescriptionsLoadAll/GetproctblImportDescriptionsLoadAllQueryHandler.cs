using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Queries.proctblImportDescriptions.GetproctblImportDescriptionsLoadAll
{
    class GetproctblImportDescriptionsLoadAllQueryHandler : IRequestHandler<GetproctblImportDescriptionsLoadAllQuery, GetproctblImportDescriptionsLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetproctblImportDescriptionsLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproctblImportDescriptionsLoadAllListVm> Handle(GetproctblImportDescriptionsLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<tblImportDescriptions> proctblImportDescriptionss = await _procedureAdabter
               .Execute<tblImportDescriptions>("[ProprtyData].[proc_tblImport_DescriptionsLoadAll]");
            GetproctblImportDescriptionsLoadAllListVm vm = new GetproctblImportDescriptionsLoadAllListVm
            {
                proctblImportDescriptionss = _mapper.Map<IList<tblImportDescriptions>, IList<GetproctblImportDescriptionsLoadAllVm>>(proctblImportDescriptionss)
            };

            return vm;
        }
    }
}
