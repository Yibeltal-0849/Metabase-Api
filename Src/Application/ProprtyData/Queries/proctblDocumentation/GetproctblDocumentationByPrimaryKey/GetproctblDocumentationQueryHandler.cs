using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.ProprtyData.Quiries.proctblDocumentation.GetproctblDocumentationLoadAll;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Quiries.proctblDocumentation.GetproctblDocumentationByPrimaryKey
{
    public class GetproctblDocumentationQueryHandler : IRequestHandler<GetproctblDocumentationByPrimaryKey, GetproctblDocumentationLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetproctblDocumentationQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproctblDocumentationLoadAllListVm> Handle(GetproctblDocumentationByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<tblDocumentation> proctblDocumentations = await _procedureAdabter
               .Execute<tblDocumentation>("[ProprtyData].[proc_tblDocumentationLoadByPrimaryKey]", request);
            GetproctblDocumentationLoadAllListVm vm = new GetproctblDocumentationLoadAllListVm
            {
                proctblDocumentations = _mapper.Map<IList<tblDocumentation>, IList<GetproctblDocumentationLoadAllVm>>(proctblDocumentations)
            };

            return vm;
        }
    }
}
