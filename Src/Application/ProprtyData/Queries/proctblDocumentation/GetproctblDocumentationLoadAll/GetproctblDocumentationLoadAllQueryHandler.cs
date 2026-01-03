using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Quiries.proctblDocumentation.GetproctblDocumentationLoadAll
{
    class GetproctblDocumentationLoadAllQueryHandler : IRequestHandler<GetproctblDocumentationLoadAllQuery, GetproctblDocumentationLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetproctblDocumentationLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproctblDocumentationLoadAllListVm> Handle(GetproctblDocumentationLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<tblDocumentation> proctblDocumentations = await _procedureAdabter
               .Execute<tblDocumentation>("[ProprtyData].[proc_tblDocumentationLoadAll]");
            GetproctblDocumentationLoadAllListVm vm = new GetproctblDocumentationLoadAllListVm
            {
                proctblDocumentations = _mapper.Map<IList<tblDocumentation>, IList<GetproctblDocumentationLoadAllVm>>(proctblDocumentations)
            };

            return vm;
        }
    }
}
