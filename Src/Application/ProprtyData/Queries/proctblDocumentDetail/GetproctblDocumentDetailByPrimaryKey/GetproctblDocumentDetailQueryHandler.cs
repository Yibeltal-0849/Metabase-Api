using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.ProprtyData.Queries.proctblDocumentDetail.GetproctblDocumentDetailLoadAll;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Queries.proctblDocumentDetail.GetproctblDocumentDetailByPrimaryKey
{
    public class GetproctblDocumentDetailQueryHandler : IRequestHandler<GetproctblDocumentDetailByPrimaryKey, GetproctblDocumentDetailLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetproctblDocumentDetailQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproctblDocumentDetailLoadAllListVm> Handle(GetproctblDocumentDetailByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<tblDocumentDetail> proctblDocumentDetails = await _procedureAdabter
               .Execute<tblDocumentDetail>("[ProprtyData].[proc_tblDocument_DetailLoadByPrimaryKey]", request);
            GetproctblDocumentDetailLoadAllListVm vm = new GetproctblDocumentDetailLoadAllListVm
            {
                proctblDocumentDetails = _mapper.Map<IList<tblDocumentDetail>, IList<GetproctblDocumentDetailLoadAllVm>>(proctblDocumentDetails)
            };

            return vm;
        }
    }
}
