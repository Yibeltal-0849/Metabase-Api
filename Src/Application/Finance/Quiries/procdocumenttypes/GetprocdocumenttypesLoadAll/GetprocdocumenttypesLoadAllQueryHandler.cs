using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.procdocumenttypes.GetprocdocumenttypesLoadAll
{
    class GetprocdocumenttypesLoadAllQueryHandler : IRequestHandler<GetprocdocumenttypesLoadAllQuery, GetprocdocumenttypesLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocdocumenttypesLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocdocumenttypesLoadAllListVm> Handle(GetprocdocumenttypesLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<documenttypes> procdocumenttypess = await _procedureAdabter
               .Execute<documenttypes>("[FINA].[proc_document_typesLoadAll]");
            GetprocdocumenttypesLoadAllListVm vm = new GetprocdocumenttypesLoadAllListVm
            {
                procdocumenttypess = _mapper.Map<IList<documenttypes>, IList<GetprocdocumenttypesLoadAllVm>>(procdocumenttypess)
            };

            return vm;
        }
    }
}
