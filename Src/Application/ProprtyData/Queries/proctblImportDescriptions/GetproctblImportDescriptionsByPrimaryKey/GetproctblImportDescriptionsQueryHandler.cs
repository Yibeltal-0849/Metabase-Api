using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.ProprtyData.Queries.proctblImportDescriptions.GetproctblImportDescriptionsLoadAll;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Queries.proctblImportDescriptions.GetproctblImportDescriptionsByPrimaryKey
{
    public class GetproctblImportDescriptionsQueryHandler : IRequestHandler<GetproctblImportDescriptionsByPrimaryKey, GetproctblImportDescriptionsLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetproctblImportDescriptionsQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproctblImportDescriptionsLoadAllListVm> Handle(GetproctblImportDescriptionsByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<tblImportDescriptions> proctblImportDescriptionss = await _procedureAdabter
               .Execute<tblImportDescriptions>("[ProprtyData].[proc_tblImport_DescriptionsLoadByPrimaryKey]", request);
            GetproctblImportDescriptionsLoadAllListVm vm = new GetproctblImportDescriptionsLoadAllListVm
            {
                proctblImportDescriptionss = _mapper.Map<IList<tblImportDescriptions>, IList<GetproctblImportDescriptionsLoadAllVm>>(proctblImportDescriptionss)
            };

            return vm;
        }
    }
}
