using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Queries.proctblDocumentDetail.GetproctblDocumentDetailLoadAll
{
    class GetproctblDocumentDetailLoadAllQueryHandler : IRequestHandler<GetproctblDocumentDetailLoadAllQuery, GetproctblDocumentDetailLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetproctblDocumentDetailLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproctblDocumentDetailLoadAllListVm> Handle(GetproctblDocumentDetailLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<tblDocumentDetail> proctblDocumentDetails = await _procedureAdabter
               .Execute<tblDocumentDetail>("[ProprtyData].[proc_tblDocument_DetailLoadAll]");
            GetproctblDocumentDetailLoadAllListVm vm = new GetproctblDocumentDetailLoadAllListVm
            {
                proctblDocumentDetails = _mapper.Map<IList<tblDocumentDetail>, IList<GetproctblDocumentDetailLoadAllVm>>(proctblDocumentDetails)
            };

            return vm;
        }
    }
}
