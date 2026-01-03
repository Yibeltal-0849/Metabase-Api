using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.procDocument_Type.GetprocDocument_TypeLoadAll
{
    class GetprocDocument_TypeLoadAllQueryHandler : IRequestHandler<GetprocDocument_TypeLoadAllQuery, GetprocDocument_TypeLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocDocument_TypeLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocDocument_TypeLoadAllListVm> Handle(GetprocDocument_TypeLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<DocumentType> procDocument_Types = await _procedureAdabter
               .Execute<DocumentType>("[FINA].[Document_TypeLoadAll]");
            GetprocDocument_TypeLoadAllListVm vm = new GetprocDocument_TypeLoadAllListVm
            {
                procDocument_Types = _mapper.Map<IList<DocumentType>, IList<GetprocDocument_TypeLoadAllVm>>(procDocument_Types)
            };

            return vm;
        }
    }
}
