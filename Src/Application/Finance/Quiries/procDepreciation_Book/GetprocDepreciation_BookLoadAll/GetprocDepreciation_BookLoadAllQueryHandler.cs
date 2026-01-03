using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.procDepreciation_Book.GetprocDepreciation_BookLoadAll
{
    class GetprocDepreciation_BookLoadAllQueryHandler : IRequestHandler<GetprocDepreciation_BookLoadAllQuery, GetprocDepreciation_BookLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocDepreciation_BookLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocDepreciation_BookLoadAllListVm> Handle(GetprocDepreciation_BookLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<Depreciation_Book> procDepreciation_Books = await _procedureAdabter
               .Execute<Depreciation_Book>("[FINA].[proc_Depreciation_BookLoadAll]");
            GetprocDepreciation_BookLoadAllListVm vm = new GetprocDepreciation_BookLoadAllListVm
            {
                procDepreciation_Books = _mapper.Map<IList<Depreciation_Book>, IList<GetprocDepreciation_BookLoadAllVm>>(procDepreciation_Books)
            };

            return vm;
        }
    }
}
