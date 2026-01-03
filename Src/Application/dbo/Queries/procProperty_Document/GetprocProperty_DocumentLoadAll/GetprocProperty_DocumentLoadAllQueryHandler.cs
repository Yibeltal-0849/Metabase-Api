using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.dbo;
using XOKA.Domain.Interfaces;

namespace Application.dbo.Quiries.procProperty_Document.GetprocProperty_DocumentLoadAll
{
    class GetprocProperty_DocumentLoadAllQueryHandler : IRequestHandler<GetprocProperty_DocumentLoadAllQuery, GetprocProperty_DocumentLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocProperty_DocumentLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocProperty_DocumentLoadAllListVm> Handle(GetprocProperty_DocumentLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<Property_Document> procProperty_Documents = await _procedureAdabter
               .Execute<Property_Document>("[dbo].[proc_Property_DocumentLoadAll]");
            GetprocProperty_DocumentLoadAllListVm vm = new GetprocProperty_DocumentLoadAllListVm
            {
                procProperty_Documents = _mapper.Map<IList<Property_Document>, IList<GetprocProperty_DocumentLoadAllVm>>(procProperty_Documents)
            };

            return vm;
        }
    }
}
