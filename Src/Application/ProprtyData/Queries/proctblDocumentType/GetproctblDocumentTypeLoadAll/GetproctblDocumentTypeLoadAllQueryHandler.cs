using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Queries.proctblDocumentType.GetproctblDocumentTypeLoadAll
{
    class GetproctblDocumentTypeLoadAllQueryHandler : IRequestHandler<GetproctblDocumentTypeLoadAllQuery, GetproctblDocumentTypeLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetproctblDocumentTypeLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproctblDocumentTypeLoadAllListVm> Handle(GetproctblDocumentTypeLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<tblDocumentType> proctblDocumentTypes = await _procedureAdabter
               .Execute<tblDocumentType>("[ProprtyData].[proc_tblDocument_TypeLoadAll]");
            GetproctblDocumentTypeLoadAllListVm vm = new GetproctblDocumentTypeLoadAllListVm
            {
                proctblDocumentTypes = _mapper.Map<IList<tblDocumentType>, IList<GetproctblDocumentTypeLoadAllVm>>(proctblDocumentTypes)
            };

            return vm;
        }
    }
}
